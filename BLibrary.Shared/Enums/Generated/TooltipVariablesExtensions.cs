namespace Blibrary.Shared.Enums.Generated;
public static class TooltipVariablesExtensions
{
    public static string ToSass(this TooltipVariables variable)
    {
        return variable switch
        {
            TooltipVariables.TooltipFontSize => "$tooltip-font-size",
            TooltipVariables.TooltipMaxWidth => "$tooltip-max-width",
            TooltipVariables.TooltipColor => "$tooltip-color",
            TooltipVariables.TooltipBg => "$tooltip-bg",
            TooltipVariables.TooltipBorderRadius => "$tooltip-border-radius",
            TooltipVariables.TooltipOpacity => "$tooltip-opacity",
            TooltipVariables.TooltipPaddingY => "$tooltip-padding-y",
            TooltipVariables.TooltipPaddingX => "$tooltip-padding-x",
            TooltipVariables.TooltipMargin => "$tooltip-margin",
            TooltipVariables.TooltipArrowWidth => "$tooltip-arrow-width",
            TooltipVariables.TooltipArrowHeight => "$tooltip-arrow-height",
            TooltipVariables.TooltipArrowColor => "$tooltip-arrow-color",
            _ => ""
        };
    }
}
