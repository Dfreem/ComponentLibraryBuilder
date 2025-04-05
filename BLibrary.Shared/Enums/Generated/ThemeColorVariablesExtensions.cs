namespace Blibrary.Shared.Enums.Generated;
public static class ThemeColorVariablesExtensions
{
    public static string ToSass(this ThemeColorVariables variable)
    {
        return variable switch
        {
            ThemeColorVariables.Primary => "$primary",
            ThemeColorVariables.Secondary => "$secondary",
            ThemeColorVariables.Success => "$success",
            ThemeColorVariables.Info => "$info",
            ThemeColorVariables.Warning => "$warning",
            ThemeColorVariables.Danger => "$danger",
            ThemeColorVariables.Light => "$light",
            ThemeColorVariables.Dark => "$dark",
            _ => ""
        };
    }
}
