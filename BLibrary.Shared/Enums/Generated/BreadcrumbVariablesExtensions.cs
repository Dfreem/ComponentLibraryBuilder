namespace Blibrary.Shared.Enums.Generated;
public static class BreadcrumbVariablesExtensions
{
    public static string ToSass(this BreadcrumbVariables variable)
    {
        return variable switch
        {
            BreadcrumbVariables.BreadcrumbFontSize => "$breadcrumb-font-size",
            BreadcrumbVariables.BreadcrumbPaddingY => "$breadcrumb-padding-y",
            BreadcrumbVariables.BreadcrumbPaddingX => "$breadcrumb-padding-x",
            BreadcrumbVariables.BreadcrumbItemPaddingX => "$breadcrumb-item-padding-x",
            BreadcrumbVariables.BreadcrumbMarginBottom => "$breadcrumb-margin-bottom",
            BreadcrumbVariables.BreadcrumbBg => "$breadcrumb-bg",
            BreadcrumbVariables.BreadcrumbDividerColor => "$breadcrumb-divider-color",
            BreadcrumbVariables.BreadcrumbActiveColor => "$breadcrumb-active-color",
            BreadcrumbVariables.BreadcrumbDivider => "$breadcrumb-divider",
            BreadcrumbVariables.BreadcrumbDividerFlipped => "$breadcrumb-divider-flipped",
            BreadcrumbVariables.BreadcrumbBorderRadius => "$breadcrumb-border-radius",
            _ => ""
        };
    }
}
