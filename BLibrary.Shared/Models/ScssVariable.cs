using Blibrary.Shared.Extensions;

using Blibrary.Shared.Helpers;

using static Blibrary.Shared.Helpers.ScssRegexHelper;

namespace Blibrary.Shared.Models;

public class ScssVariable
{
    public string Key { get; set; } = "";
    public string Value { get; set; } = "";

    public bool IsVariable { get; set; }

    private string _original = "";

    private string _unit = "";

    public string Unit { get => _unit; set => _unit = value == "none" ?  "" :  value; }

    public string Original { get => _original; set => _original = Value; }

    public void ResetToPrevious()
    {
        Value = _original;
    }

    public bool IsChecked { get; set; }
    public string InputType()
    {
      
        string result = Key switch
        {
            var _ when (Key.Contains("bg") && !Key.Contains("image") || Key.Contains("color") || Value.ScssIsColor()) && !Key.Contains("shadow") && Key != "border" => "color",
            var _ when Key.Contains("show") || Key.Contains("enable") => "checkbox",
            var _ when Key == "border" || Key.Contains("shadow") => "multi-4",
            var _ when Key.Contains("padding") || Key.Contains("margin") || Key.Contains("radius") || Key.Contains("z-index") || Key.Contains("spacing") || Key.Contains("width") || Key.Contains("height") => "number",
            _ => "text"
        };
        return result;
    }

    public string ToCss(string prefix = "--bs-")
    {
        string value = IsVariable ? prefix:"";
        value += Key.Kabobify().Replace("$", "") + ": " + Value + Unit + ";";
        return value;
    }

    public string ToScss(int indentLevel = 1)
    {
        string key = Key;
        for (int i = 0; i < indentLevel; i++)
        {
            key += "\t";
        }
        if (key.Contains('$'))
            return $"{key}: {Value};";

        return $"${key}: {Value}";
    }


}

