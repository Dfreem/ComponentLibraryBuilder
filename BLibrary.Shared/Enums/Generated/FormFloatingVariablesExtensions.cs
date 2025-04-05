namespace Blibrary.Shared.Enums.Generated;
public static class FormFloatingVariablesExtensions
{
    public static string ToSass(this FormFloatingVariables variable)
    {
        return variable switch
        {
            FormFloatingVariables.FormFloatingHeight => "$form-floating-height",
            FormFloatingVariables.FormFloatingLineHeight => "$form-floating-line-height",
            FormFloatingVariables.FormFloatingPaddingX => "$form-floating-padding-x",
            FormFloatingVariables.FormFloatingPaddingY => "$form-floating-padding-y",
            FormFloatingVariables.FormFloatingInputPaddingT => "$form-floating-input-padding-t",
            FormFloatingVariables.FormFloatingInputPaddingB => "$form-floating-input-padding-b",
            FormFloatingVariables.FormFloatingLabelHeight => "$form-floating-label-height",
            FormFloatingVariables.FormFloatingLabelOpacity => "$form-floating-label-opacity",
            FormFloatingVariables.FormFloatingLabelTransform => "$form-floating-label-transform",
            FormFloatingVariables.FormFloatingLabelDisabledColor => "$form-floating-label-disabled-color",
            FormFloatingVariables.FormFloatingTransition => "$form-floating-transition",
            _ => ""
        };
    }
}
