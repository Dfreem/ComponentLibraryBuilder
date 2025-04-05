using Blibrary.Shared.Enums;

using Microsoft.AspNetCore.Components;

namespace Blibrary.Shared.Components.Base;

public class StyleableBaseComponent : ComponentBase
{
    [Parameter]
    public virtual string? Class { get; set; }

    [Parameter]
    public virtual string? Style { get; set; }

    [Parameter]
    public BootstrapColor? BgColor { get; set; }

}
