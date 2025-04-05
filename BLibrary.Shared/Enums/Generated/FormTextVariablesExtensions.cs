namespace Blibrary.Shared.Enums.Generated;
public static class FormTextVariablesExtensions
{
    public static string ToSass(this FormTextVariables variable)
    {
        return variable switch
        {
            FormTextVariables.FormTextMarginTop => "$form-text-margin-top",
            FormTextVariables.FormTextFontSize => "$form-text-font-size",
            FormTextVariables.FormTextFontStyle => "$form-text-font-style",
            FormTextVariables.FormTextFontWeight => "$form-text-font-weight",
            FormTextVariables.FormTextColor => "$form-text-color",
            _ => ""
        };
    }
}
