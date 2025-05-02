using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Blibrary.Shared.Components.Base;
using Blibrary.Shared.Models;

using Microsoft.AspNetCore.Components;

namespace Blibrary.Shared.Components.Form;
public class InputBase<T> : StyleableBaseComponent
{
    [Parameter]
    public virtual T Value { get; set; } = default!;

    [Parameter]
    public EventCallback<T> ValueChanged { get; set; }

    [Parameter, EditorRequired]
    public string Key { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public string? Unit { get; set; }


    [Parameter]
    public EventCallback<string> UnitChanged { get; set; }

}
