namespace Blibrary.Shared.Services.FileWalkerService;
public class FileTree
{
    public Dictionary<string, string> FileContents { get; set; } = [];
    public DirNode RootNode { get; set; } = new();
}
