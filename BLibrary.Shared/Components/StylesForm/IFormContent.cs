using Blibrary.Shared.Models;

using Microsoft.AspNetCore.Components;

namespace Blibrary.Shared.Components.StylesForm;

public interface IFormContent
{
    public ScssVariableSection CurrentSection { get; set; }
    public EventCallback<(string Key, bool Value)> CheckRule { get; set; }

    public EventCallback<(string Key, string? Value)> SetRuleValue { get; set; }

    public EventCallback<string> CheckOptionsBox { get; set; }
}
