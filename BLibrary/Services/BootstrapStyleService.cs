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

    private string[] _include = [
        "modal",
        "accordion",
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
                    if (section.Rules.Count == 0)
                        continue;
                    results.Add(section);
                }
                catch (Exception ex)
                {
                    Log.Error("unable to parse file {item}\n {ex}", ex);
                }
            }

            // theme color variables for populating color dropdown by variable name
            var colorSections = sections.Where(s => s.Success && s.Groups.Count > 1 && s.Groups[0].Value.Contains("color-variables"));
            ScssVariableSection themeColorVariables = new() { SectionTitle = "color-variables" };
            foreach (var colorVartiablesSection in colorSections)
            {
                var sectionTitle = titleGrabber.Match(colorVartiablesSection.Value);
                var scssRuleGrabber = ScssRegexHelper.ScssRuleGrabber();
                var rules = scssRuleGrabber.Matches(colorVartiablesSection.Value);
                var ruleList = rules.Where(r => r.Success && !r.Groups[1].Value.Contains("zindex") && r.Groups[2].Value.ScssIsColor()) // ignore z-index variables
                    .Select(r =>
                    {
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

                themeColorVariables.Rules.AddRange(ruleList);
            }
            results.Add(themeColorVariables);

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
