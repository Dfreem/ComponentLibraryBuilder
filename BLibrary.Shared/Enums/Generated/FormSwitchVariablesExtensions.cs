namespace Blibrary.Shared.Enums.Generated;
public static class FormSwitchVariablesExtensions
{
    public static string ToSass(this FormSwitchVariables variable)
    {
        return variable switch
        {
            FormSwitchVariables.FormSwitchColor => "$form-switch-color",
            FormSwitchVariables.FormSwitchWidth => "$form-switch-width",
            FormSwitchVariables.FormSwitchPaddingStart => "$form-switch-padding-start",
            FormSwitchVariables.FormSwitchBgImage => "$form-switch-bg-image",
            FormSwitchVariables.FormSwitchBorderRadius => "$form-switch-border-radius",
            FormSwitchVariables.FormSwitchTransition => "$form-switch-transition",
            FormSwitchVariables.FormSwitchFocusColor => "$form-switch-focus-color",
            FormSwitchVariables.FormSwitchFocusBgImage => "$form-switch-focus-bg-image",
            FormSwitchVariables.FormSwitchCheckedColor => "$form-switch-checked-color",
            FormSwitchVariables.FormSwitchCheckedBgImage => "$form-switch-checked-bg-image",
            FormSwitchVariables.FormSwitchCheckedBgPosition => "$form-switch-checked-bg-position",
            _ => ""
        };
    }
}
