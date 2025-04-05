namespace Blibrary.Shared.Enums.Generated;
public static class FocusRingVariablesExtensions
{
    public static string ToSass(this FocusRingVariables variable)
    {
        return variable switch
        {
            FocusRingVariables.FocusRingWidth => "$focus-ring-width",
            FocusRingVariables.FocusRingOpacity => "$focus-ring-opacity",
            FocusRingVariables.FocusRingColor => "$focus-ring-color",
            FocusRingVariables.FocusRingBlur => "$focus-ring-blur",
            FocusRingVariables.FocusRingBoxShadow => "$focus-ring-box-shadow",
            _ => ""
        };
    }
}
