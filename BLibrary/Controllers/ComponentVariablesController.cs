using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Blibrary.Shared.Enums;
using Blibrary.Shared.Models;

namespace Blibrary.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ComponentVariablesController : ControllerBase
{
    //[HttpGet("section/{tComponent}")]
    //public ActionResult<ScssVariableSection> GetComponentSections(ComponentType tComponent)
    //{
    //    return tComponent switch
    //    {
    //        _ => GetDefaultSection()
    //    };
    //}

    //private ScssVariableSection GetDefaultSection()
    //{
    //    return new() 
    //    {
    //        SectionType = ComponentType.None,
    //        Rules = new()
    //        {
    //            new(){  } 
    //    }
    //}
}
