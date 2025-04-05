namespace Blibrary.Shared.Enums.Generated;
public static class OffcanvasVariablesExtensions
{
    public static string ToSass(this OffcanvasVariables variable)
    {
        return variable switch
        {
            OffcanvasVariables.OffcanvasPaddingY => "$offcanvas-padding-y",
            OffcanvasVariables.OffcanvasPaddingX => "$offcanvas-padding-x",
            OffcanvasVariables.OffcanvasHorizontalWidth => "$offcanvas-horizontal-width",
            OffcanvasVariables.OffcanvasVerticalHeight => "$offcanvas-vertical-height",
            OffcanvasVariables.OffcanvasTransitionDuration => "$offcanvas-transition-duration",
            OffcanvasVariables.OffcanvasBorderColor => "$offcanvas-border-color",
            OffcanvasVariables.OffcanvasBorderWidth => "$offcanvas-border-width",
            OffcanvasVariables.OffcanvasTitleLineHeight => "$offcanvas-title-line-height",
            OffcanvasVariables.OffcanvasBgColor => "$offcanvas-bg-color",
            OffcanvasVariables.OffcanvasColor => "$offcanvas-color",
            OffcanvasVariables.OffcanvasBoxShadow => "$offcanvas-box-shadow",
            OffcanvasVariables.OffcanvasBackdropBg => "$offcanvas-backdrop-bg",
            OffcanvasVariables.OffcanvasBackdropOpacity => "$offcanvas-backdrop-opacity",
            _ => ""
        };
    }
}
