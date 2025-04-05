namespace Blibrary.Shared.Enums.Generated;
public static class FormLabelVariablesExtensions
{
    public static string ToSass(this FormLabelVariables variable)
    {
        return variable switch
        {
            FormLabelVariables.FormLabelMarginBottom => "$form-label-margin-bottom",
            FormLabelVariables.FormLabelFontSize => "$form-label-font-size",
            FormLabelVariables.FormLabelFontStyle => "$form-label-font-style",
            FormLabelVariables.FormLabelFontWeight => "$form-label-font-weight",
            FormLabelVariables.FormLabelColor => "$form-label-color",
            _ => ""
        };
    }
}
