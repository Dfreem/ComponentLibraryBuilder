using Blibrary.Shared.DTO;
using Blibrary.Shared.Models;

using Serilog;

using System.Net.Http.Json;

namespace Blibrary.Shared.Services.CMSServices;
public class SassClient
{
    HttpClient _client;



    public event EventHandler<ColorEventArgs>? OnSelectionChanged;

    public SassClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<StyleVariablesResponse?> GetVariableCollectionAsync() => await _client.GetFromJsonAsync<StyleVariablesResponse>("api/FileContent/bootstrapVariables");

    public async Task<Stream?> Compile(List<ScssVariableSection> sections, List<ScssVariable> variants, Dictionary<string, string>? colorOvveride)
    {
        Stream? result = null;
        try
        {
            CompileParams args = new() { ColorSection = variants, Sections = sections, ColorMap = colorOvveride };
            var response = await _client.PostAsJsonAsync<CompileParams>("api/FileContent/compile-sass", args);
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
