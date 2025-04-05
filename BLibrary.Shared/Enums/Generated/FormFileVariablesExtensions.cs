namespace Blibrary.Shared.Enums.Generated;
public static class FormFileVariablesExtensions
{
    public static string ToSass(this FormFileVariables variable)
    {
        return variable switch
        {
            FormFileVariables.FormFileButtonColor => "$form-file-button-color",
            FormFileVariables.FormFileButtonBg => "$form-file-button-bg",
            FormFileVariables.FormFileButtonHoverBg => "$form-file-button-hover-bg",
            _ => ""
        };
    }
}
