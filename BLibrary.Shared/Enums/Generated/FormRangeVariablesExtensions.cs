namespace Blibrary.Shared.Enums.Generated;
public static class FormRangeVariablesExtensions
{
    public static string ToSass(this FormRangeVariables variable)
    {
        return variable switch
        {
            FormRangeVariables.FormRangeTrackWidth => "$form-range-track-width",
            FormRangeVariables.FormRangeTrackHeight => "$form-range-track-height",
            FormRangeVariables.FormRangeTrackCursor => "$form-range-track-cursor",
            FormRangeVariables.FormRangeTrackBg => "$form-range-track-bg",
            FormRangeVariables.FormRangeTrackBorderRadius => "$form-range-track-border-radius",
            FormRangeVariables.FormRangeTrackBoxShadow => "$form-range-track-box-shadow",
            FormRangeVariables.FormRangeThumbWidth => "$form-range-thumb-width",
            FormRangeVariables.FormRangeThumbHeight => "$form-range-thumb-height",
            FormRangeVariables.FormRangeThumbBg => "$form-range-thumb-bg",
            FormRangeVariables.FormRangeThumbBorder => "$form-range-thumb-border",
            FormRangeVariables.FormRangeThumbBorderRadius => "$form-range-thumb-border-radius",
            FormRangeVariables.FormRangeThumbBoxShadow => "$form-range-thumb-box-shadow",
            FormRangeVariables.FormRangeThumbFocusBoxShadow => "$form-range-thumb-focus-box-shadow",
            FormRangeVariables.FormRangeThumbFocusBoxShadowWidth => "$form-range-thumb-focus-box-shadow-width",
            FormRangeVariables.FormRangeThumbActiveBg => "$form-range-thumb-active-bg",
            FormRangeVariables.FormRangeThumbDisabledBg => "$form-range-thumb-disabled-bg",
            FormRangeVariables.FormRangeThumbTransition => "$form-range-thumb-transition",
            _ => ""
        };
    }
}
