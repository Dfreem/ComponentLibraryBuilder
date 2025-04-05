namespace Blibrary.Shared.Enums.Generated;
public static class FormSelectVariablesExtensions
{
    public static string ToSass(this FormSelectVariables variable)
    {
        return variable switch
        {
            FormSelectVariables.FormSelectPaddingY => "$form-select-padding-y",
            FormSelectVariables.FormSelectPaddingX => "$form-select-padding-x",
            FormSelectVariables.FormSelectFontFamily => "$form-select-font-family",
            FormSelectVariables.FormSelectFontSize => "$form-select-font-size",
            FormSelectVariables.FormSelectIndicatorPadding => "$form-select-indicator-padding",
            FormSelectVariables.FormSelectFontWeight => "$form-select-font-weight",
            FormSelectVariables.FormSelectLineHeight => "$form-select-line-height",
            FormSelectVariables.FormSelectColor => "$form-select-color",
            FormSelectVariables.FormSelectBg => "$form-select-bg",
            FormSelectVariables.FormSelectDisabledColor => "$form-select-disabled-color",
            FormSelectVariables.FormSelectDisabledBg => "$form-select-disabled-bg",
            FormSelectVariables.FormSelectDisabledBorderColor => "$form-select-disabled-border-color",
            FormSelectVariables.FormSelectBgPosition => "$form-select-bg-position",
            FormSelectVariables.FormSelectBgSize => "$form-select-bg-size",
            FormSelectVariables.FormSelectIndicatorColor => "$form-select-indicator-color",
            FormSelectVariables.FormSelectIndicator => "$form-select-indicator",
            FormSelectVariables.FormSelectFeedbackIconPaddingEnd => "$form-select-feedback-icon-padding-end",
            FormSelectVariables.FormSelectFeedbackIconPosition => "$form-select-feedback-icon-position",
            FormSelectVariables.FormSelectFeedbackIconSize => "$form-select-feedback-icon-size",
            FormSelectVariables.FormSelectBorderWidth => "$form-select-border-width",
            FormSelectVariables.FormSelectBorderColor => "$form-select-border-color",
            FormSelectVariables.FormSelectBorderRadius => "$form-select-border-radius",
            FormSelectVariables.FormSelectBoxShadow => "$form-select-box-shadow",
            FormSelectVariables.FormSelectFocusBorderColor => "$form-select-focus-border-color",
            FormSelectVariables.FormSelectFocusWidth => "$form-select-focus-width",
            FormSelectVariables.FormSelectFocusBoxShadow => "$form-select-focus-box-shadow",
            FormSelectVariables.FormSelectPaddingYSm => "$form-select-padding-y-sm",
            FormSelectVariables.FormSelectPaddingXSm => "$form-select-padding-x-sm",
            FormSelectVariables.FormSelectFontSizeSm => "$form-select-font-size-sm",
            FormSelectVariables.FormSelectBorderRadiusSm => "$form-select-border-radius-sm",
            FormSelectVariables.FormSelectPaddingYLg => "$form-select-padding-y-lg",
            FormSelectVariables.FormSelectPaddingXLg => "$form-select-padding-x-lg",
            FormSelectVariables.FormSelectFontSizeLg => "$form-select-font-size-lg",
            FormSelectVariables.FormSelectBorderRadiusLg => "$form-select-border-radius-lg",
            FormSelectVariables.FormSelectTransition => "$form-select-transition",
            _ => ""
        };
    }
}
