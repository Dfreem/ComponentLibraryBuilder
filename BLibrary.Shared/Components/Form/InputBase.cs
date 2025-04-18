using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Blibrary.Shared.Components.Base;
using Blibrary.Shared.Models;

using Microsoft.AspNetCore.Components;

namespace Blibrary.Shared.Components.Form;
public class InputBase : StyleableBaseComponent
{
    [Parameter]
    public virtual ScssVariable Rule { get; set; } = default!;

    [Parameter]
    public EventCallback<ScssVariable> RuleChanged { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

}
