using Blibrary.Shared.Models;

using Microsoft.AspNetCore.Components;

namespace Blibrary.Client.Shared.Components.StylesForm;

public interface IFormContent
{
    public List<ScssVariableSection> Variables { get; set; }
    public ScssVariableSection CurrentSection { get; set; }
    public EventCallback<(string Key, bool Value)> CheckRule { get; set; }

    public EventCallback<(string Key, string? Value)> SetRuleValue { get; set; }

    public EventCallback<string> CheckOptionsBox { get; set; }
}
