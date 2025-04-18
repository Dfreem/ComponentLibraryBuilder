using Blibrary.Shared.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Extensions.AppExtensions;

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


    public static List<ScssVariableSection>? ColorSection(this List<ScssVariableSection> sections)
    {

        return sections.Where(v => v.SectionTitle.Contains("color-variables")).ToList();

    }
}
