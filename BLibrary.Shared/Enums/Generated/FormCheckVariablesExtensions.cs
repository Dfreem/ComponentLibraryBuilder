namespace Blibrary.Shared.Enums.Generated;
public static class FormCheckVariablesExtensions
{
    public static string ToSass(this FormCheckVariables variable)
    {
        return variable switch
        {
            FormCheckVariables.FormCheckInputWidth => "$form-check-input-width",
            FormCheckVariables.FormCheckMinHeight => "$form-check-min-height",
            FormCheckVariables.FormCheckPaddingStart => "$form-check-padding-start",
            FormCheckVariables.FormCheckMarginBottom => "$form-check-margin-bottom",
            FormCheckVariables.FormCheckLabelColor => "$form-check-label-color",
            FormCheckVariables.FormCheckLabelCursor => "$form-check-label-cursor",
            FormCheckVariables.FormCheckTransition => "$form-check-transition",
            FormCheckVariables.FormCheckInputActiveFilter => "$form-check-input-active-filter",
            FormCheckVariables.FormCheckInputBg => "$form-check-input-bg",
            FormCheckVariables.FormCheckInputBorder => "$form-check-input-border",
            FormCheckVariables.FormCheckInputBorderRadius => "$form-check-input-border-radius",
            FormCheckVariables.FormCheckRadioBorderRadius => "$form-check-radio-border-radius",
            FormCheckVariables.FormCheckInputFocusBorder => "$form-check-input-focus-border",
            FormCheckVariables.FormCheckInputFocusBoxShadow => "$form-check-input-focus-box-shadow",
            FormCheckVariables.FormCheckInputCheckedColor => "$form-check-input-checked-color",
            FormCheckVariables.FormCheckInputCheckedBgColor => "$form-check-input-checked-bg-color",
            FormCheckVariables.FormCheckInputCheckedBorderColor => "$form-check-input-checked-border-color",
            FormCheckVariables.FormCheckInputCheckedBgImage => "$form-check-input-checked-bg-image",
            FormCheckVariables.FormCheckRadioCheckedBgImage => "$form-check-radio-checked-bg-image",
            FormCheckVariables.FormCheckInputIndeterminateColor => "$form-check-input-indeterminate-color",
            FormCheckVariables.FormCheckInputIndeterminateBgColor => "$form-check-input-indeterminate-bg-color",
            FormCheckVariables.FormCheckInputIndeterminateBorderColor => "$form-check-input-indeterminate-border-color",
            FormCheckVariables.FormCheckInputIndeterminateBgImage => "$form-check-input-indeterminate-bg-image",
            FormCheckVariables.FormCheckInputDisabledOpacity => "$form-check-input-disabled-opacity",
            FormCheckVariables.FormCheckLabelDisabledOpacity => "$form-check-label-disabled-opacity",
            FormCheckVariables.FormCheckBtnCheckDisabledOpacity => "$form-check-btn-check-disabled-opacity",
            FormCheckVariables.FormCheckInlineMarginEnd => "$form-check-inline-margin-end",
            _ => ""
        };
    }
}
