using Blibrary.Shared.Models;

using Serilog;

using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

using Blibrary.Shared.Helpers;

namespace Blibrary.Services;
public class BootstrapStyleService
{

    private string[] _ignore = [
        "close",
        "button-group",
        "container",
        "grid," +
        "helpers",
        "grid",
        "list-groups",
        "maps",
        "mixins",
        "bootstrap",
        "bootstrap-grid",
        "bootstrap-reboot",
        "bootstrap-utilities"
        ];

    private string[] _hasVariants = [
        "btn"
        ];

    public BootstrapStyleService()
    {

    }
    public async Task<List<ScssVariableSection>> GetBaseVariablesAsync()
    {
        List<ScssVariableSection> results = new();
        try
        {
            Regex scssSectionGrabber = ScssRegexHelper.ScssSectionGrabber();
            Regex titleGrabber = ScssRegexHelper.ScssSectionStartPattern();
            Regex ruleGrabber = ScssRegexHelper.CssRuleGrabber();
            string bootstrapScssVariables = await File.ReadAllTextAsync(Path.GetFullPath("./wwwroot/lib/bootstrap/scss/_variables.scss"));
            var templateFiles = Directory.GetFiles("wwwroot/scss/components/templates/").Select(f => Path.GetFileName(f).Replace("_", "").Replace(".scss", "")).Where(f => !_ignore.Contains(f));
            var sections = scssSectionGrabber.Matches(bootstrapScssVariables);

            // get individual bootstrap components
            foreach (var item in templateFiles)
            {
                try
                {
                    // use the filenames to find section variables inside the compiled css file. These file names match the section title and variable prefix
                    // example: scss filename -> _modal.scss; section variable prefix -> modal
                    // in the example, modal will be able to find any css classes that begin with modal
                    //var bsFiles = Directory.GetFiles("wwwroot/bootstrap/scss/").Select(f => Path.GetFileName(f).Replace("_", "").Replace(".scss", "")).Where(f => !_ignore.Contains(f));
                    var fileStyle = await File.ReadAllTextAsync(Path.GetFullPath($"./wwwroot/scss/components/templates/_{item}.scss"));
                    ScssVariableSection section = new(fileStyle, item);
                    section.HasVariants = _hasVariants.Contains(item);
                    if (section.Rules.Count == 0)
                        continue;
                    results.Add(section);
                }
                catch (Exception ex)
                {
                    Log.Error("unable to parse file {item}\n {ex}", ex);
                }
            }

            // theme color variables for populating color dropdown by name and generating color variants
            Match? colorSection = null;
            foreach (Match section in sections)
            {
                if(!section.Success || section.Groups.Count <= 1)
                    continue;

                // sections start with `// scss-docs-start {section title}
                var sectionContent = section.Groups[0].Value;
                var titleMatch = titleGrabber.Match(sectionContent);

                // title-grabber grabs the entire line, ex: // scss-docs-start color-variables -> ["//", "scss-docs-start", "color-vartiables"]
                var titleParts = titleMatch.Groups[0].Value.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                var title = titleParts[^1];
                if(title == "color-variables")
                {
                    colorSection = section;
                    break;
                }
            }

            ScssVariableSection themeColorVariables = new() { SectionTitle = "color-variables" };
            // extract color variables
            if (colorSection is not null)
            {
                var sectionTitle = titleGrabber.Match(colorSection.Value);
                var scssRuleGrabber = ScssRegexHelper.ScssRuleGrabber();
                var rules = scssRuleGrabber.Matches(colorSection.Value);
                var ruleList = rules.Where(
                    r => r.Success && 
                    !r.Groups[1].Value.Contains("zindex") && // ignore z-index variables
                    r.Groups[2].Value.ScssIsColor())
                    .Select(r =>
                    {
                        // Regex.Match includes the entire match in the first position of the array and then the captured groups
                        // if there are less then 3 groups, the match didn't work
                        string value = r.Groups.Count > 2 ? r.Groups[2].Value.Replace("!default", "").Trim() : "";
                        string noHashtag = value.Replace("#", "");
                        if (noHashtag.Length <= 3)
                        {
                            value = value + noHashtag;
                        }
                        return new ScssVariable()
                        {
                            Key = r.Groups[1].Value,
                            Original = r.Groups[1].Value,
                            Value = value
                        };
                    }).DistinctBy(r => r.Key);

                themeColorVariables.Rules = [.. ruleList];
                results.Add(themeColorVariables);
            }

        }
        catch (Exception ex)
        {
            Log.Error("an error ocurred while retrieving bootstrap variables\n{err}", ex);
        }
        return results;

    }

    public async Task<ScssVariableSection> GetOptionsSection()
    {
        string bootstrapOptions = await File.ReadAllTextAsync(Path.GetFullPath("./wwwroot/scss/_options.scss"));
        Regex variablesGrabber = new(@"^\$([\w-]*):\W+(.*);", RegexOptions.Multiline);
        var optionRuleMatches = variablesGrabber.Matches(bootstrapOptions);
        var optionRules = optionRuleMatches.Select(m =>
        {
            var ruleValue = m.Groups[2].Value.Replace("!default", "").Trim();
            Console.WriteLine(ruleValue);
            bool ruleBool = false;
            try
            {
                ruleBool = Convert.ToBoolean(ruleValue);
            }
            catch (Exception ex)
            {
                Log.Error("error occurred while processing bootstrap options\n {ex}", ex);
            }

            var rule = new ScssVariable()
            {
                Key = m.Groups[1].Value,
                IsChecked = ruleBool,
                Value = ruleBool.ToString().ToLower()
            };
            rule.Original = rule.Value;
            return rule;
        });

        return new() { Rules = [.. optionRules], SectionTitle = "options", SectionType = Shared.Enums.ComponentType.Options };

    }

    //public ScssVariableSection GetModalSection()
    //{
    //    ScssVariableSection section = new ScssVariableSection()
    //    {
    //        SectionTitle = "modal",
    //        SectionType = Shared.Enums.ComponentType.Modal,
    //        Rules = [

    //            ]
    //    };
    //}
}
