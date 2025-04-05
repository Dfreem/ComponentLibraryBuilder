namespace Blibrary.Shared.Enums.Generated;
public static class ProgressVariablesExtensions
{
    public static string ToSass(this ProgressVariables variable)
    {
        return variable switch
        {
            ProgressVariables.ProgressHeight => "$progress-height",
            ProgressVariables.ProgressFontSize => "$progress-font-size",
            ProgressVariables.ProgressBg => "$progress-bg",
            ProgressVariables.ProgressBorderRadius => "$progress-border-radius",
            ProgressVariables.ProgressBoxShadow => "$progress-box-shadow",
            ProgressVariables.ProgressBarColor => "$progress-bar-color",
            ProgressVariables.ProgressBarBg => "$progress-bar-bg",
            ProgressVariables.ProgressBarAnimationTiming => "$progress-bar-animation-timing",
            ProgressVariables.ProgressBarTransition => "$progress-bar-transition",
            _ => ""
        };
    }
}
