using Blibrary.Shared.Models;

namespace Blibrary.Shared.DTO;

public class CompileParams
{
    public List<ScssVariableSection> Sections { get; set; } = [];
    public List<ScssVariable> ColorSection { get; set; } = [];
    public Dictionary<string, string>? ColorMap { get; set; }
}
