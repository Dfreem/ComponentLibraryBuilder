using System.Text.RegularExpressions;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Serilog;
using Blibrary.Shared.Helpers;
using Blibrary.Shared.Services;
using Blibrary.Shared.Services.FileWalkerService;
using System.Reflection.PortableExecutable;
using Blibrary.Shared.Extensions;
using Blibrary.Services;
using Blibrary.Shared.Models;
using AspNetCore.SassCompiler;
using System.Text;
using Blibrary.Shared.DTO;

namespace Blibrary.Controllers;

[Route("api/[controller]")]
[ApiController]
public partial class FileContentController : ControllerBase
{

    private BootstrapStyleService _bootstrapStyleService;
    private ISassCompiler _sassCompiler;
    private Dictionary<string, string> _replacements = new()
    {
        {"btn" , "buttons"}
    };

    string[] _ignores = [
        "color-variables"
        ];

    public FileContentController(BootstrapStyleService bootstrapStyleService, ISassCompiler sassCompiler)
    {
        _bootstrapStyleService = bootstrapStyleService;
        _sassCompiler = sassCompiler;
    }

    ////TODO delete this
    //[HttpPost("file-tree")]
    //public FileTree GetFileTree([FromBody]string[] pathArray)
    //{
    //    string filepath = String.Join("/", pathArray);
    //    if(pathArray.Length == 0)
    //    {
    //        filepath = "./";
    //    }
    //    FileTree result = new()
    //    {
    //        RootNode = FileWalker.WalkDirs(filepath)
    //    };
    //    foreach (var path in result.RootNode.Files)
    //    {
    //        var content = System.IO.File.ReadAllText(path);
    //        result.FileContents.Add(path, content);
    //    }
    //    return result;
    //}

    [HttpGet("section-names")]
    public List<string> GetSectionNamesAsync()
    {
        return _bootstrapStyleService.GetSectionNames();
    }

    [HttpPost("compile-sass")]
    public async Task<string> CompileSass([FromBody] CompileParams args)
    {
        string scssPath = String.Empty;
        string result = "";

        args.Sections.ColorSectionVariables();
        Regex importsGrabber = ScssRegexHelper.ScssImportsGrabber();


        string fileContents = "";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_functions.scss") + "\n\n";

        // bootstrap theme color overrides
        var themeColors = args.ColorMap?.Select(c =>
        {
            return $"${c.Key}: {c.Value};\n";
        }).ToArray();
        if(themeColors is not null)
            fileContents += String.Join('\n', themeColors);

        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_variables.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_variables-dark.scss") + "\n\n";

        //fileContents = fileContents.Replace("@import \"variables-dark\";", "");
        if (args.ColorSection.Count > 0)
        {
            var (fileThemeVariables, fileThemeMap) = ProcessThemeColors(args.ColorSection, args.ColorMap);
            fileContents += fileThemeVariables;
            fileContents += fileThemeMap;
        }
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_maps.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_mixins.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_utilities.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/vendor/_rfs.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_root.scss") + "\n\n";
        foreach (var section in args.Sections.Where(s => s.Compile))
        {
            fileContents += System.IO.File.ReadAllText($"./wwwroot/lib/bootstrap/scss/_{section.SectionTitle}.scss") + "\n\n";
            fileContents += section.ToScssSection() + "\n";
            string sectionTitle = section.SectionTitle;
            if (_replacements.ContainsKey(section.SectionTitle))
                sectionTitle = _replacements[section.SectionTitle];
            if (_ignores.Contains(section.SectionTitle))
                continue;

            fileContents += section.EndOfFile;

        }
        try
        {
            //string[] lines = fileContents.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            //lines = [.. lines.Where(l => !l.StartsWith("@import"))];
            //fileContents = String.Join("\n", lines);
            scssPath = Path.GetFullPath("./wwwroot/temp/scss/custom.scss");
            byte[] buffer = UnicodeEncoding.Default.GetBytes(fileContents);
            System.IO.File.WriteAllBytes(scssPath, buffer);
            using var stream = new MemoryStream(buffer);
            result = await _sassCompiler.CompileToStringAsync(stream, [
                "--quiet", "--quiet-deps",
                "--load-path=./wwwroot/lib/bootstrap/scss/vendor",
                "--load-path=./wwwroot/lib/bootstrap/scss/mixins",
                "--load-path=./wwwroot/lib/bootstrap/scss",
                "--load-path=./wwwroot/lib/bootstrap/scss/helpers",
                "--load-path=./wwwroot/lib/bootstrap/scss/utilities",
                "--load-path=./wwwroot/lib/bootstrap/scss/forms"
            ]);
            if (!String.IsNullOrEmpty(scssPath) && System.IO.File.Exists(scssPath))
                System.IO.File.Delete(scssPath);
            if (System.IO.File.Exists("./wwwroot/temp/css.custom.css"))
                System.IO.File.Delete("./wwwroot/temp/css.custom.css");
        }
        catch (Exception ex)
        {
            Log.Error("Error while compiling sass\n{ex}", ex);
        }

        //using Stream stream = System.IO.File.Create();
        return result;
    }

    /// <summary>
    /// Get all the editable bootstrap content. the list of <see cref="ScssVariableSection"/> returned contains sections and variables for default bootstrap components and styles.
    /// </summary>
    /// <remarks>
    /// <see cref="ScssVariableSection"/> as well as the <see cref="ScssVariable"/>'s the it owns contain method for converting and manipulating the underlying scss/css
    /// </remarks>
    /// <returns>A list of editable component sections containing variables that control the look and feel of the customized components </returns>
    [HttpGet("bootstrapVariables")]
    public async Task<StyleVariablesResponse> GetBootstrapVariables() => await _bootstrapStyleService.GetBaseVariablesAsync();

    private (string themeColorVariables, string themeColorMap) ProcessThemeColors(List<ScssVariable> colors, Dictionary<string, string>? colorVariableOverrides)
    {
        string themeColorVariables = "";
        string themeColorMap = "$theme-colors: map-merge-multiple(";
        foreach (ScssVariable color in colors)
        {
            themeColorVariables += $"${color.Key}: {color.Value};\n";
            themeColorMap += $"${color.Key}s, ";
        }
        if (colorVariableOverrides is not null)
        {
            foreach (var color in colorVariableOverrides)
            {
                themeColorVariables += $"${color.Key}: {color.Value};\n";
                themeColorMap += $"${color.Key}s, ";

            }
        }
        themeColorMap = themeColorMap.Remove(themeColorMap.LastIndexOf(','), 1);
        themeColorMap += ");\n";
        return (themeColorVariables, themeColorMap);
    }

}
