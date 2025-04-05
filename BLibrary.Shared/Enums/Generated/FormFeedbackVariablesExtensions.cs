namespace Blibrary.Shared.Enums.Generated;
public static class FormFeedbackVariablesExtensions
{
    public static string ToSass(this FormFeedbackVariables variable)
    {
        return variable switch
        {
            FormFeedbackVariables.FormFeedbackMarginTop => "$form-feedback-margin-top",
            FormFeedbackVariables.FormFeedbackFontSize => "$form-feedback-font-size",
            FormFeedbackVariables.FormFeedbackFontStyle => "$form-feedback-font-style",
            FormFeedbackVariables.FormFeedbackValidColor => "$form-feedback-valid-color",
            FormFeedbackVariables.FormFeedbackInvalidColor => "$form-feedback-invalid-color",
            FormFeedbackVariables.FormFeedbackIconValidColor => "$form-feedback-icon-valid-color",
            FormFeedbackVariables.FormFeedbackIconValid => "$form-feedback-icon-valid",
            FormFeedbackVariables.FormFeedbackIconInvalidColor => "$form-feedback-icon-invalid-color",
            FormFeedbackVariables.FormFeedbackIconInvalid => "$form-feedback-icon-invalid",
            _ => ""
        };
    }
}
