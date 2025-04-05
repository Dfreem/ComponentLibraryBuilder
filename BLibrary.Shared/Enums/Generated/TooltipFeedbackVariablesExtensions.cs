namespace Blibrary.Shared.Enums.Generated;
public static class TooltipFeedbackVariablesExtensions
{
    public static string ToSass(this TooltipFeedbackVariables variable)
    {
        return variable switch
        {
            TooltipFeedbackVariables.FormFeedbackTooltipPaddingY => "$form-feedback-tooltip-padding-y",
            TooltipFeedbackVariables.FormFeedbackTooltipPaddingX => "$form-feedback-tooltip-padding-x",
            TooltipFeedbackVariables.FormFeedbackTooltipFontSize => "$form-feedback-tooltip-font-size",
            TooltipFeedbackVariables.FormFeedbackTooltipLineHeight => "$form-feedback-tooltip-line-height",
            TooltipFeedbackVariables.FormFeedbackTooltipOpacity => "$form-feedback-tooltip-opacity",
            TooltipFeedbackVariables.FormFeedbackTooltipBorderRadius => "$form-feedback-tooltip-border-radius",
            _ => ""
        };
    }
}
