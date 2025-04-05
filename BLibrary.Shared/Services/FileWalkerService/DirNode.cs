namespace Blibrary.Shared.Services.FileWalkerService;

public class DirNode
{
    public string Name { get; set; } = default!;

    public DirNode[] Dirs { get; set; } = [];

    public string[] Files { get; set; } = [];
}
