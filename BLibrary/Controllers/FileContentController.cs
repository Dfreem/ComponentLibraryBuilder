using System.Text.RegularExpressions;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Serilog;
using Blibrary.Shared.Helpers;
using Blibrary.Shared.Services;
using Blibrary.Shared.Services.FileWalkerService;
using System.Reflection.PortableExecutable;
using Blibrary.Shared.Extensions;
using Blibrary.Services;
using Blibrary.Shared.Models;
using AspNetCore.SassCompiler;
using System.Text;

namespace Blibrary.Controllers;

[Route("api/[controller]")]
[ApiController]
public partial class FileContentController : ControllerBase
{

    private BootstrapStyleService _bootstrapStyleService;
    private ISassCompiler _sassCompiler;
    private Dictionary<string, string> _replacements = new()
    {
        {"btn" , "buttons"}
    };

    string[] _ignores = [
        "color-variables"
        ];

    public FileContentController(BootstrapStyleService bootstrapStyleService, ISassCompiler sassCompiler)
    {
        _bootstrapStyleService = bootstrapStyleService;
        _sassCompiler = sassCompiler;
    }

    ////TODO delete this
    //[HttpPost("file-tree")]
    //public FileTree GetFileTree([FromBody]string[] pathArray)
    //{
    //    string filepath = String.Join("/", pathArray);
    //    if(pathArray.Length == 0)
    //    {
    //        filepath = "./";
    //    }
    //    FileTree result = new()
    //    {
    //        RootNode = FileWalker.WalkDirs(filepath)
    //    };
    //    foreach (var path in result.RootNode.Files)
    //    {
    //        var content = System.IO.File.ReadAllText(path);
    //        result.FileContents.Add(path, content);
    //    }
    //    return result;
    //}

    [HttpPost("compile-sass")]
    public async Task<string> CompileSass([FromBody] List<ScssVariableSection> sections)
    {
        string scssPath = String.Empty;
        string result = "";

        Regex importsGrabber = ScssRegexHelper.ScssImportsGrabber();

        string fileContents = "";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_functions.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_variables.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_variables-dark.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_maps.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_mixins.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_utilities.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/vendor/_rfs.scss") + "\n\n";
        fileContents += System.IO.File.ReadAllText("./wwwroot/lib/bootstrap/scss/_root.scss") + "\n\n";
        foreach (var section in sections.Where(s => s.Rules.Any(r => r.IsChecked)))
        {
            fileContents += section.ToScssSection() + "\n";
            string sectionTitle = section.SectionTitle;
            if (_replacements.ContainsKey(section.SectionTitle))
                sectionTitle = _replacements[section.SectionTitle];
            if (_ignores.Contains(section.SectionTitle))
                continue;

            fileContents += System.IO.File.ReadAllText($"./wwwroot/lib/bootstrap/scss/_{sectionTitle}.scss") + "\n";

        }
        try
        {
            //string[] lines = fileContents.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            //lines = [.. lines.Where(l => !l.StartsWith("@import"))];
            //fileContents = String.Join("\n", lines);
            scssPath = Path.GetFullPath("./wwwroot/temp/scss/custom.scss");
            byte[] buffer = UnicodeEncoding.Default.GetBytes(fileContents);
            System.IO.File.WriteAllBytes(scssPath, buffer);
            using var stream = new MemoryStream(buffer);
            result = await _sassCompiler.CompileToStringAsync(stream, [
                "--quiet", "--quiet-deps",
                "--load-path=./wwwroot/lib/bootstrap/scss/mixins",
                "--load-path=./wwwroot/lib/bootstrap/scss/",
                "--load-path=./wwwroot/lib/bootstrap/scss/helpers",
                "--load-path=./wwwroot/lib/bootstrap/scss/utilities",
                "--load-path=./wwwroot/lib/bootstrap/scss/forms"
            ]);
        }
        catch (Exception ex)
        {
            Log.Error("Error while compiling sass\n{ex}", ex);
        }
        finally
        {
            if (!String.IsNullOrEmpty(scssPath) && System.IO.File.Exists(scssPath))
                System.IO.File.Delete(scssPath);
            if (System.IO.File.Exists("./wwwroot/temp/css.custom.css"))
                System.IO.File.Delete("./wwwroot/temp/css.custom.css");
        }

        //using Stream stream = System.IO.File.Create();
        return result;
    }

    private string ValueReplace(string value)
    {
        if (value.Contains("#{$"))
            value = value.Replace("#{$", "var(--").Replace("}", ");");
        else
            value = "";
        //else if (value.StartsWith("#{"))
        //    value = value.Replace("#{", "var(--").Replace("}", ");");

        return value;
    }

    /// <summary>
    /// Get all the editable bootstrap content. the list of <see cref="ScssVariableSection"/> returned contains sections and variables for default bootstrap components and styles.
    /// </summary>
    /// <remarks>
    /// <see cref="ScssVariableSection"/> as well as the <see cref="ScssVariable"/>'s the it owns contain method for converting and manipulating the underlying scss/css
    /// </remarks>
    /// <returns>A list of editable component sections containing variables that control the look and feel of the customized components </returns>
    [HttpGet("bootstrapVariables")]
    public async Task<List<ScssVariableSection>> GetBootstrapVariables() => await _bootstrapStyleService.GetBaseVariablesAsync();

}
