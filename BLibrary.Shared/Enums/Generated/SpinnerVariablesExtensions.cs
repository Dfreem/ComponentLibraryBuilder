namespace Blibrary.Shared.Enums.Generated;
public static class SpinnerVariablesExtensions
{
    public static string ToSass(this SpinnerVariables variable)
    {
        return variable switch
        {
            SpinnerVariables.SpinnerWidth => "$spinner-width",
            SpinnerVariables.SpinnerHeight => "$spinner-height",
            SpinnerVariables.SpinnerVerticalAlign => "$spinner-vertical-align",
            SpinnerVariables.SpinnerBorderWidth => "$spinner-border-width",
            SpinnerVariables.SpinnerAnimationSpeed => "$spinner-animation-speed",
            SpinnerVariables.SpinnerWidthSm => "$spinner-width-sm",
            SpinnerVariables.SpinnerHeightSm => "$spinner-height-sm",
            SpinnerVariables.SpinnerBorderWidthSm => "$spinner-border-width-sm",
            _ => ""
        };
    }
}
