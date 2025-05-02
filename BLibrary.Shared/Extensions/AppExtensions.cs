using Blibrary.Shared.Models;
using Blibrary.Shared.Services.CMSServices;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Extensions;

public static class ServiceProviderExtensioins
{
    public static IServiceCollection AddCommonServices(this IServiceCollection services, Uri baseAddress)
    {
        services.AddHttpClient<SassClient>(client => client.BaseAddress = baseAddress);
        services.AddSingleton<ISassCompilationService, SassCompilationService>();

        return services;
    }
}

public static class SectionListExtensions
{
    public static string ToCss(this List<ScssVariableSection> sectionList)
    {
        string result = "";
        foreach (var section in sectionList.Where(s => s.Rules.Any(r => r.IsChecked)))
        {
            result += "\t" + section.ToCssSection();

        }
        return result;
    }
    public static string ToScss(this List<ScssVariableSection> sectionList)
    {
        string result = "";
        foreach (var section in sectionList.Where(s => s.Rules.Any(r => r.IsChecked)))
        {
            result += section.ToScssSection();

        }
        return result;
    }


    public static List<ScssVariableSection>? GetAllColorSections(this List<ScssVariableSection> sections)
    {

        return sections.Where(v => v.SectionTitle.Contains("color-variables")).ToList();

    }

    public static List<ScssVariable>? ColorSectionVariables(this List<ScssVariableSection> sections)
    {
        var colorSection = sections.FirstOrDefault(s => s.SectionTitle == "color-variables");
        return colorSection?.Rules;
    }

    public static Dictionary<string, string> ToColorMap(this List<ScssVariable> section)
    {
        return section.ToDictionary(s => s.Key, s => s.Value);
    }
}
