namespace Blibrary.Shared.Enums.Generated;
public static class FormInputVariablesExtensions
{
    public static string ToSass(this FormInputVariables variable)
    {
        return variable switch
        {
            FormInputVariables.InputPaddingY => "$input-padding-y",
            FormInputVariables.InputPaddingX => "$input-padding-x",
            FormInputVariables.InputFontFamily => "$input-font-family",
            FormInputVariables.InputFontSize => "$input-font-size",
            FormInputVariables.InputFontWeight => "$input-font-weight",
            FormInputVariables.InputLineHeight => "$input-line-height",
            FormInputVariables.InputPaddingYSm => "$input-padding-y-sm",
            FormInputVariables.InputPaddingXSm => "$input-padding-x-sm",
            FormInputVariables.InputFontSizeSm => "$input-font-size-sm",
            FormInputVariables.InputPaddingYLg => "$input-padding-y-lg",
            FormInputVariables.InputPaddingXLg => "$input-padding-x-lg",
            FormInputVariables.InputFontSizeLg => "$input-font-size-lg",
            FormInputVariables.InputBg => "$input-bg",
            FormInputVariables.InputDisabledColor => "$input-disabled-color",
            FormInputVariables.InputDisabledBg => "$input-disabled-bg",
            FormInputVariables.InputDisabledBorderColor => "$input-disabled-border-color",
            FormInputVariables.InputColor => "$input-color",
            FormInputVariables.InputBorderColor => "$input-border-color",
            FormInputVariables.InputBorderWidth => "$input-border-width",
            FormInputVariables.InputBoxShadow => "$input-box-shadow",
            FormInputVariables.InputBorderRadius => "$input-border-radius",
            FormInputVariables.InputBorderRadiusSm => "$input-border-radius-sm",
            FormInputVariables.InputBorderRadiusLg => "$input-border-radius-lg",
            FormInputVariables.InputFocusBg => "$input-focus-bg",
            FormInputVariables.InputFocusBorderColor => "$input-focus-border-color",
            FormInputVariables.InputFocusColor => "$input-focus-color",
            FormInputVariables.InputFocusWidth => "$input-focus-width",
            FormInputVariables.InputFocusBoxShadow => "$input-focus-box-shadow",
            FormInputVariables.InputPlaceholderColor => "$input-placeholder-color",
            FormInputVariables.InputPlaintextColor => "$input-plaintext-color",
            FormInputVariables.InputHeightBorder => "$input-height-border",
            FormInputVariables.InputHeightInner => "$input-height-inner",
            FormInputVariables.InputHeightInnerHalf => "$input-height-inner-half",
            FormInputVariables.InputHeightInnerQuarter => "$input-height-inner-quarter",
            FormInputVariables.InputHeight => "$input-height",
            FormInputVariables.InputHeightSm => "$input-height-sm",
            FormInputVariables.InputHeightLg => "$input-height-lg",
            FormInputVariables.InputTransition => "$input-transition",
            FormInputVariables.FormColorWidth => "$form-color-width",
            _ => ""
        };
    }
}
