namespace Blibrary.Shared.Enums.Generated;
public static class BorderVariablesExtensions
{
    public static string ToSass(this BorderVariables variable)
    {
        return variable switch
        {
            BorderVariables.BorderWidth => "$border-width",
            BorderVariables.BorderStyle => "$border-style",
            BorderVariables.BorderColor => "$border-color",
            BorderVariables.BorderColorTranslucent => "$border-color-translucent",
            _ => ""
        };
    }
}
