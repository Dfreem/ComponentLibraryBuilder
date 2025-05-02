using Blibrary.Shared.Enums;
using Blibrary.Shared.Enums.Style;

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

    [Parameter]
    public string Id { get; set; } = Guid.NewGuid().ToString();

}
