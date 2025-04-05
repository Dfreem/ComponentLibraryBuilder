namespace Blibrary.Shared.Enums.Generated;
public static class FormValidationColorsExtensions
{
    public static string ToSass(this FormValidationColors variable)
    {
        return variable switch
        {
            FormValidationColors.FormValidColor => "$form-valid-color",
            FormValidationColors.FormValidBorderColor => "$form-valid-border-color",
            FormValidationColors.FormInvalidColor => "$form-invalid-color",
            FormValidationColors.FormInvalidBorderColor => "$form-invalid-border-color",
            _ => ""
        };
    }
}
