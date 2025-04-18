using Blibrary.Shared.Models;

using Serilog;

using System.Net.Http.Json;

namespace Blibrary.Shared.Services.CMSServices;
public class StyleVariablesService : IStyleVariablesService
{

    HttpClient _client;
    public StyleVariablesService(HttpClient client)
    {
        _client = client;
    }

    public async Task<List<ScssVariableSection>?> GetVariableCollectionAsync() => await _client.GetFromJsonAsync<List<ScssVariableSection>>("api/FileContent/bootstrapVariables");

    public async Task<Stream?> Compile(List<ScssVariableSection> sections)
    {
        Stream? result = null;
        try
        {
            var response = await _client.PostAsJsonAsync<List<ScssVariableSection>>("api/FileContent/compile-sass", sections);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStreamAsync();
            }
        }
        catch (Exception ex)
        {
            Log.Error("An error occurred while compiling sass\n{ex}", ex);
        }
        return result;
    }

    //public async Task<string> GenerateCssFromSection(ScssVariableSection section)
    //{
    //    //var response = await _client.PostAsJsonAsync($"api/FileContent/generate/css", section);
    //    //if (response.IsSuccessStatusCode)
    //    //    return await response.Content.ReadAsStringAsync();
    //    //return "";

    //}

    public async Task<string> GenerateScssFromSection(ScssVariableSection section)
    {
        var response = await _client.PostAsJsonAsync($"api/FileContent/generate/scss", section);
        if (response.IsSuccessStatusCode)
            return await response.Content.ReadAsStringAsync();
        return "";

    }
}
