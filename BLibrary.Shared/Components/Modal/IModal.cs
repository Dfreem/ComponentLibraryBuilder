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
    public bool NoJS { get; set; }
}

public abstract class ModalBase : ComponentBase, IModal, IAsyncDisposable
{
    [CascadingParameter]
    public CascadingModalManager? ModalManager { get; set; }
    [Parameter]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public ElementReference ModalRef { get; set; } = new();

    [Parameter]
    public bool NoJS { get; set; }

    public ValueTask DisposeAsync()
    {
        if (ModalManager is not null)
        {
            ModalManager.RemoveChild(this);
        }
        GC.SuppressFinalize(this);
        return ValueTask.CompletedTask;
    }
}

