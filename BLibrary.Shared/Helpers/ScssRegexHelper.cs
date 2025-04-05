using System.Text.RegularExpressions;

using Serilog;

using Blibrary.Shared.Models;

namespace Blibrary.Shared.Helpers;

public static partial class ScssRegexHelper
{

    [GeneratedRegex(@"[""']([^""']+)[""']\s*:\s*([^,\n)]+)(?=,|\n|\))")]
    public static partial Regex MapGrabber();

    [GeneratedRegex(@"[\w|\W]*:\s*\(\s*([""']\w+[""']\s*:\s*[^,]+,\s*)*([""']\w+[""']\s*:\s*[^,]+)\s*\)\s*?", RegexOptions.NonBacktracking, 5000)]
    public static partial Regex MapSyntaxValidator();

    [GeneratedRegex(@"\$(.*):\s+(.*);", RegexOptions.NonBacktracking, 5000)]
    public static partial Regex ScssRuleGrabber();

    [GeneratedRegex(@"-?-?(.*):\s+(.*);", RegexOptions.NonBacktracking, 5000)]
    public static partial Regex CssRuleGrabber();
    [GeneratedRegex(@"(#[0123456789abcdefg]{3,6})|((?:rgb)a?.+);", RegexOptions.Multiline | RegexOptions.NonBacktracking, 5000)]
    public static partial Regex ScssColorChecker();

    [GeneratedRegex(@"//\s*scss-docs-start\b.*\n([\s\S]*?)//\s*scss-docs-end\b", RegexOptions.NonBacktracking | RegexOptions.Multiline, 20000)]
    public static partial Regex ScssSectionGrabber();

    [GeneratedRegex(@"// scss-docs-start\s(.*)\n")]
    public static partial Regex ScssSectionStartPattern();

    [GeneratedRegex(@":root,\W\[data-bs-theme=light]\W{((?:\W.*\W))+}", RegexOptions.Multiline)]
    public static partial Regex CssRootGrabber();

    [GeneratedRegex("--bs-([\\w-]+):\\s*([^;]+);")]
    public static partial Regex CssVariableGrabber();

    public static bool IsScssMap(string scssContent)
    {
        Regex mapPattern = MapSyntaxValidator();

        Regex aRegex = MultiPartCssValuePattern();
        try
        {
            var result = mapPattern.IsMatch(scssContent);
            return result;
        }
        catch (Exception ex)
        {
            Log.Error("Regex Match Error\n{err}", ex);
            return false;
        }
    }
    public static Dictionary<string, string> MapToDictionary(string section)
    {
        Dictionary<string, string> result = [];
        Regex mapGrabber = ScssRegexHelper.MapGrabber();
        IList<Match> mapMatches = (IList<Match>)mapGrabber.Matches(section);
        foreach (var group in mapMatches)
        {
            IList<Group> groups = (IList<Group>)group.Groups;
            if (group.Length > 2)
            {
                result.Add(groups[1].Value, groups[2].Value);
            }
        }
        return result;
    }


    public static bool ScssIsColor(this string value)
    {
        var colorGrabber = ScssColorChecker();
        return colorGrabber.IsMatch(value);
    }

    public static string GrabCssRootDefinition(this string input)
    {
        Regex rootGrabber = CssRootGrabber();
        var root = rootGrabber.Match(input);
        if (root.Success)
        {
            return root.Captures[0].Value;
        }
        return "";
    }

    public static string[] ParseMultiValueInput(this string input)
    {
        Regex multiValueGrabber = MultiPartCssValuePattern();
        var matches = multiValueGrabber.Matches(input);
        if(matches.Count > 0)
            return [.. matches[0].Groups.Values.Select(v => v.Value)];
        return [];
    }

    [GeneratedRegex(@":\W*(-?\w*)\W(-?\w*)\W(-?\w*)\W(-?\w*)\W(.*);", RegexOptions.Multiline)]
    private static partial Regex MultiPartCssValuePattern();
}