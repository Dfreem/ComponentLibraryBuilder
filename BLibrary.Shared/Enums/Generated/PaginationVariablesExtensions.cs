namespace Blibrary.Shared.Enums.Generated;
public static class PaginationVariablesExtensions
{
    public static string ToSass(this PaginationVariables variable)
    {
        return variable switch
        {
            PaginationVariables.PaginationPaddingY => "$pagination-padding-y",
            PaginationVariables.PaginationPaddingX => "$pagination-padding-x",
            PaginationVariables.PaginationPaddingYSm => "$pagination-padding-y-sm",
            PaginationVariables.PaginationPaddingXSm => "$pagination-padding-x-sm",
            PaginationVariables.PaginationPaddingYLg => "$pagination-padding-y-lg",
            PaginationVariables.PaginationPaddingXLg => "$pagination-padding-x-lg",
            PaginationVariables.PaginationFontSize => "$pagination-font-size",
            PaginationVariables.PaginationColor => "$pagination-color",
            PaginationVariables.PaginationBg => "$pagination-bg",
            PaginationVariables.PaginationBorderRadius => "$pagination-border-radius",
            PaginationVariables.PaginationBorderWidth => "$pagination-border-width",
            PaginationVariables.PaginationMarginStart => "$pagination-margin-start",
            PaginationVariables.PaginationBorderColor => "$pagination-border-color",
            PaginationVariables.PaginationFocusColor => "$pagination-focus-color",
            PaginationVariables.PaginationFocusBg => "$pagination-focus-bg",
            PaginationVariables.PaginationFocusBoxShadow => "$pagination-focus-box-shadow",
            PaginationVariables.PaginationFocusOutline => "$pagination-focus-outline",
            PaginationVariables.PaginationHoverColor => "$pagination-hover-color",
            PaginationVariables.PaginationHoverBg => "$pagination-hover-bg",
            PaginationVariables.PaginationHoverBorderColor => "$pagination-hover-border-color",
            PaginationVariables.PaginationActiveColor => "$pagination-active-color",
            PaginationVariables.PaginationActiveBg => "$pagination-active-bg",
            PaginationVariables.PaginationActiveBorderColor => "$pagination-active-border-color",
            PaginationVariables.PaginationDisabledColor => "$pagination-disabled-color",
            PaginationVariables.PaginationDisabledBg => "$pagination-disabled-bg",
            PaginationVariables.PaginationDisabledBorderColor => "$pagination-disabled-border-color",
            PaginationVariables.PaginationTransition => "$pagination-transition",
            PaginationVariables.PaginationBorderRadiusSm => "$pagination-border-radius-sm",
            PaginationVariables.PaginationBorderRadiusLg => "$pagination-border-radius-lg",
            _ => ""
        };
    }
}
