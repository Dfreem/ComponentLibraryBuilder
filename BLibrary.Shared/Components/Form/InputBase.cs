using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Blibrary.Shared.Models;

using Microsoft.AspNetCore.Components;

namespace Blibrary.Shared.Components.Form;
public class InputBase : ComponentBase
{
    [Parameter]
    public string Class { get; set; } = "";

    [Parameter]
    public virtual ScssVariable Rule { get; set; } = default!;

    [Parameter]
    public EventCallback<ScssVariable> RuleChanged { get; set; }

}
