using Blibrary.Shared.Components.DisplayComponentTemplates;
using Blibrary.Shared.Components.StylesForm;
using Blibrary.Shared.Enums;
using Blibrary.Shared.Helpers;

using Serilog;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Blibrary.Shared.Models;
public partial class ScssVariableSection
{
    public string SectionTitle { get; set; } = "";

    // TODO parse and set this on instantiation
    public ComponentType SectionType { get; set; }

    public Type GetComponentType()
    {
        return SectionTitle switch
        {
            "btn" => typeof(ButtonTemplate),
            _ => typeof(DefaultFormContent)
        };
    }

    public bool IsMap { get; set; }

    public List<ScssVariable> Rules { get; set; } = [];

    public List<ScssVariable> ColorVariations { get; set; } = [];

    public List<ScssVariable> NonEditableRules { get; set; } = [];

    /// <summary>
    /// Return stringified scss version of this section. The content is prepended by scss docs markers and it's title
    /// </summary>
    /// <returns>scss format variables as a string</returns>
    public override string ToString()
    {
        string result = $" // scss-docs-start {SectionTitle} \n";
        foreach (var rule in Rules.Where(r => r.IsChecked))
        {
            result += $"${rule.Key}: {rule.Value};\n";
        }
        result += $" // scss-docs-end {SectionTitle}\n\n";
        return result;
    }

    public string ToCssSection(bool includeRules = true)
    {

        if (!Rules.Any(r => r.IsChecked))
        {
            return "";
        }
        string result = $".{SectionTitle} {{\n";
        foreach (var rule in Rules.Where(r => r.IsChecked))
        {
            result += $"{rule.ToCss()}\n";
        }
        result += "\n";

        if (!includeRules)
            return result;


        foreach (var rule in NonEditableRules)
        {
            result += $"\t{rule.ToCss()}\n";
        }
        result += "}\n";
        return result;
    }

    public string ToScssSection()
    {

        if (!Rules.Any(r => r.IsChecked))
        {
            return "";
        }
        string result = "";
        foreach (var rule in Rules.Where(r => r.IsChecked))
        {
            result += $"{rule.ToScss()};\n";
        }
        result += "\n";
        //if (Common.Any(c => c.IsChecked))
        //{
        //    foreach (var rule in Common.Where(r => r.IsChecked))
        //    {
        //        result += $"\t{rule.Key}: {rule.Value}{rule.Unit};\n";

        //    }
        //}
        return result;
    }

    public ScssVariableSection()
    {
    }
    public ScssVariableSection(string sectionString, string sectionName)
    {
        SectionTitle = sectionName;
        ProcessCssSection(sectionString);

    }


    private void ProcessCssSection(string sectionString, bool preserverRules = false)
    {
        string pattern = $"\\.{SectionTitle}" + @"-?\w*\W*{([^}])*}";
        Regex sectionGrabber = new(pattern);
        var sectionMatch = sectionGrabber.Match(sectionString);
        if (!sectionMatch.Success)
        {
            Log.Error("unable to match section {sectionName}", SectionTitle);
            return;
        }

        if (!preserverRules)
            Rules.Clear();

        Regex ruleGrabber = ScssRegexHelper.CssRuleGrabber();
        var rules = ruleGrabber.Matches(sectionMatch.Value);
        NonEditableRules = rules.Where(r => !r.Groups[1].Value.Trim().StartsWith("--"))
            .Select(r => new ScssVariable()
            {
                Key = r.Groups[1].Value.Trim(),
                Original = r.Groups[2].Value.Trim(),
                Value = r.Groups[2].Value.Trim(),
                IsVariable = false
            })
            .ToList();

        var ruleList = rules.Where(r => r.Success && !r.Groups[1].Value.Contains("zindex") && !NonEditableRules.Any(s => s.Key == r.Groups[1].Value.Trim())) // ignore z-index variables
            .Select(r => new ScssVariable()
            {
                Key = r.Groups[1].Value.Replace("--bs-", "").Trim(),
                Original = r.Groups[1].Value.Trim(),
                IsVariable = true,
                Value = r.Groups.Count > 2 ? r.Groups[2].Value.Trim() : ""
            }).DistinctBy(r => r.Key);
        Rules.AddRange(ruleList);

        // as a dictionary does, we don't want any duplicate keys TODO be smarter about keeping the new item
        Rules = [.. Rules.DistinctBy(r => r.Key)];
    }

}

