using Blibrary.Shared.Models;

namespace Blibrary.Shared.DTO;

public class StyleVariablesResponse
{
    public List<ScssVariableSection> Sections { get; set; } = [];
    public ScssVariableSection ColorSection { get; set; } = default!;
}
