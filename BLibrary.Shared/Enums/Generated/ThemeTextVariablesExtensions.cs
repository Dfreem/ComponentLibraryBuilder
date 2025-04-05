namespace Blibrary.Shared.Enums.Generated;
public static class ThemeTextVariablesExtensions
{
    public static string ToSass(this ThemeTextVariables variable)
    {
        return variable switch
        {
            ThemeTextVariables.PrimaryTextEmphasis => "$primary-text-emphasis",
            ThemeTextVariables.SecondaryTextEmphasis => "$secondary-text-emphasis",
            ThemeTextVariables.SuccessTextEmphasis => "$success-text-emphasis",
            ThemeTextVariables.InfoTextEmphasis => "$info-text-emphasis",
            ThemeTextVariables.WarningTextEmphasis => "$warning-text-emphasis",
            ThemeTextVariables.DangerTextEmphasis => "$danger-text-emphasis",
            ThemeTextVariables.LightTextEmphasis => "$light-text-emphasis",
            ThemeTextVariables.DarkTextEmphasis => "$dark-text-emphasis",
            _ => ""
        };
    }
}
