using Blibrary.Shared.Models;

namespace Blibrary.Shared.Services.CMSServices;
public interface IStyleVariablesService
{
    Task<string> GenerateCssFromSection(ScssVariableSection section);
    Task<List<ScssVariableSection>?> GetVariableCollectionAsync();
}