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

namespace Blibrary.Controllers;

[Route("api/[controller]")]
[ApiController]
public partial class FileContentController : ControllerBase
{
  
    private BootstrapStyleService _bootstrapStyleService;

    public FileContentController(BootstrapStyleService bootstrapStyleService)
    {
        _bootstrapStyleService = bootstrapStyleService;
    }

    // TODO delete this
    //[HttpGet("file-tree")]
    //public FileTree GetFileTree()
    //{
    //    FileTree result = new()
    //    {
    //        RootNode = FileWalker.WalkDirs("./")
    //    };
    //    return result;
    //}

    /// <summary>
    /// Get all the editable bootstrap content. the list of <see cref="ScssVariableSection"/> returned contains sections and variables for default bootstrap components and styles.
    /// </summary>
    /// <remarks>
    /// <see cref="ScssVariableSection"/> as well as the <see cref="ScssVariable"/>'s the it owns contain method for converting and manipulating the underlying scss/css
    /// </remarks>
    /// <returns>A list of editable component sections containing variables that control the look and feel of the customized components </returns>
    [HttpGet("bootstrapVariables")]
    public async Task<List<ScssVariableSection>> GetBootstrapVariables() => await _bootstrapStyleService.GetBaseVariablesAsync();

    [HttpPost]
    public ActionResult<string> GenerateCssSection([FromBody] ScssVariableSection section)
    {
        /*example output
         * .modal {
         *      --modal-bg: #111111;
         *      --modal-padding-x: .25em;
         * } 
         */
        string result = "";
        var bsFiles = Directory.GetFiles("wwwroot/bootstrap/scss/").Select(f => Path.GetFileName(f).Replace("_", "").Replace(".scss", ""));

        // use the filename because they match the css rules to generate.
        // TODO change this name if you don't need to interact with a file.
        var sectionFilename = bsFiles.FirstOrDefault(f => section.SectionTitle.StartsWith(f));
        if (string.IsNullOrEmpty(sectionFilename))
        {
            Log.Error("Unable to match section to file\n{sectionTitle}", section.SectionTitle);
            return "";
        }
        // begin the css rule
        result += "." + sectionFilename + "{\n\t";

        // generate css variable from section parameters and end the css rule.
        result += section.ToCssSection() + "\n}\n";

        return result;
    }

    //[HttpPost("generate-stylesheet")]
    //public async Task<FileResult> GenerateStylString([FromBody] List<ScssVariableSection> variables)
    //{
    //    string fileContent = "test content";
    //    FormFile file = new()
    //        //foreach (var section in variables.Sections)
    //    //{
    //    //}
    //}

}
