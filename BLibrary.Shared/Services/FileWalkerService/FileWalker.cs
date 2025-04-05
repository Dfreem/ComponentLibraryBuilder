using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.JSInterop;

using Serilog;

namespace Blibrary.Shared.Services.FileWalkerService;
public static class FileWalker
{

    public static DirNode WalkDirs(string dirName)
    {
        string[] topDirs = [];
        DirNode node = new()
        {
            Name = dirName
        };
        try
        {
            topDirs = Directory.GetDirectories(dirName);
        }
        catch (Exception ex)
        {
            Log.Error("error while accessing directory {dir}\n\n{err}", dirName, ex);
            node.Name = "error while accessing directory";
            return node;
        }
        EnumerationOptions option = new()
        {
            RecurseSubdirectories = true,
            MaxRecursionDepth = 10,
            ReturnSpecialDirectories = true
        };
        node.Files = Directory.GetFiles(dirName, "*", option);

        foreach (var item in topDirs)
        {
            node.Dirs = [.. node.Dirs, WalkDirs(item)];
        }
        return node;
    }

}
