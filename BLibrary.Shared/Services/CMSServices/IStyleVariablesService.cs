using Blibrary.Shared.Models;

namespace Blibrary.Shared.Services.CMSServices
{
    public interface IStyleVariablesService
    {
        Task<Stream?> Compile(List<ScssVariableSection> sections);
        Task<string> GenerateScssFromSection(ScssVariableSection section);
        Task<List<ScssVariableSection>?> GetVariableCollectionAsync();
    }
}