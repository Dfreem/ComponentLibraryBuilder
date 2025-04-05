using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Blibrary.Shared.Models;

namespace Blibrary.Shared.Components.Modal;

public interface IModal
{
    public CascadingModalManager? ModalManager { get; set; }
    public string Id { get; set; }

    public ElementReference ModalRef { get; set; }
}

public abstract class ModalBase : ComponentBase, IModal
{
    [CascadingParameter]
    public CascadingModalManager? ModalManager { get; set; }
    [Parameter]
    public string Id { get; set; } = "";
    public ElementReference ModalRef { get; set; } = new();
}
