namespace Blibrary.Shared.Enums.Generated;
public static class ThemeBgSubtleVariablesExtensions
{
    public static string ToSass(this ThemeBgSubtleVariables variable)
    {
        return variable switch
        {
            ThemeBgSubtleVariables.PrimaryBgSubtle => "$primary-bg-subtle",
            ThemeBgSubtleVariables.SecondaryBgSubtle => "$secondary-bg-subtle",
            ThemeBgSubtleVariables.SuccessBgSubtle => "$success-bg-subtle",
            ThemeBgSubtleVariables.InfoBgSubtle => "$info-bg-subtle",
            ThemeBgSubtleVariables.WarningBgSubtle => "$warning-bg-subtle",
            ThemeBgSubtleVariables.DangerBgSubtle => "$danger-bg-subtle",
            ThemeBgSubtleVariables.LightBgSubtle => "$light-bg-subtle",
            ThemeBgSubtleVariables.DarkBgSubtle => "$dark-bg-subtle",
            _ => ""
        };
    }
}
