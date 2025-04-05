namespace Blibrary.Shared.Enums.Generated;
public static class InputBtnVariablesExtensions
{
    public static string ToSass(this InputBtnVariables variable)
    {
        return variable switch
        {
            InputBtnVariables.InputBtnPaddingY => "$input-btn-padding-y",
            InputBtnVariables.InputBtnPaddingX => "$input-btn-padding-x",
            InputBtnVariables.InputBtnFontFamily => "$input-btn-font-family",
            InputBtnVariables.InputBtnFontSize => "$input-btn-font-size",
            InputBtnVariables.InputBtnLineHeight => "$input-btn-line-height",
            InputBtnVariables.InputBtnFocusWidth => "$input-btn-focus-width",
            InputBtnVariables.InputBtnFocusColorOpacity => "$input-btn-focus-color-opacity",
            InputBtnVariables.InputBtnFocusColor => "$input-btn-focus-color",
            InputBtnVariables.InputBtnFocusBlur => "$input-btn-focus-blur",
            InputBtnVariables.InputBtnFocusBoxShadow => "$input-btn-focus-box-shadow",
            InputBtnVariables.InputBtnPaddingYSm => "$input-btn-padding-y-sm",
            InputBtnVariables.InputBtnPaddingXSm => "$input-btn-padding-x-sm",
            InputBtnVariables.InputBtnFontSizeSm => "$input-btn-font-size-sm",
            InputBtnVariables.InputBtnPaddingYLg => "$input-btn-padding-y-lg",
            InputBtnVariables.InputBtnPaddingXLg => "$input-btn-padding-x-lg",
            InputBtnVariables.InputBtnFontSizeLg => "$input-btn-font-size-lg",
            InputBtnVariables.InputBtnBorderWidth => "$input-btn-border-width",
            _ => ""
        };
    }
}
