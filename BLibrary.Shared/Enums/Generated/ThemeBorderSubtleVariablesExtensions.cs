namespace Blibrary.Shared.Enums.Generated;
public static class ThemeBorderSubtleVariablesExtensions
{
    public static string ToSass(this ThemeBorderSubtleVariables variable)
    {
        return variable switch
        {
            ThemeBorderSubtleVariables.PrimaryBorderSubtle => "$primary-border-subtle",
            ThemeBorderSubtleVariables.SecondaryBorderSubtle => "$secondary-border-subtle",
            ThemeBorderSubtleVariables.SuccessBorderSubtle => "$success-border-subtle",
            ThemeBorderSubtleVariables.InfoBorderSubtle => "$info-border-subtle",
            ThemeBorderSubtleVariables.WarningBorderSubtle => "$warning-border-subtle",
            ThemeBorderSubtleVariables.DangerBorderSubtle => "$danger-border-subtle",
            ThemeBorderSubtleVariables.LightBorderSubtle => "$light-border-subtle",
            ThemeBorderSubtleVariables.DarkBorderSubtle => "$dark-border-subtle",
            _ => ""
        };
    }
}
