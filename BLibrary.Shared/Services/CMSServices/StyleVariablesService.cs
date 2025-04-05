using Blibrary.Shared.Models;

using System.Net.Http.Json;

namespace Blibrary.Shared.Services.CMSServices;
public class StyleVariablesService : IStyleVariablesService
{

    HttpClient _client;
    public StyleVariablesService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri("https://localhost:7044");
    }

    public async Task<List<ScssVariableSection>?> GetVariableCollectionAsync() => await _client.GetFromJsonAsync<List<ScssVariableSection>>("api/FileContent/bootstrapVariables");

    public async Task<string> GenerateCssFromSection(ScssVariableSection section)
    {
        var response = await _client.PostAsJsonAsync("api/FileContent", section);
        if (response.IsSuccessStatusCode)
            return await response.Content.ReadAsStringAsync();
        return "";

    }
}
