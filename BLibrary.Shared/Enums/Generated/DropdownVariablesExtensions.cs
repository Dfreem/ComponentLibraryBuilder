namespace Blibrary.Shared.Enums.Generated;
public static class DropdownVariablesExtensions
{
    public static string ToSass(this DropdownVariables variable)
    {
        return variable switch
        {
            DropdownVariables.DropdownMinWidth => "$dropdown-min-width",
            DropdownVariables.DropdownPaddingX => "$dropdown-padding-x",
            DropdownVariables.DropdownPaddingY => "$dropdown-padding-y",
            DropdownVariables.DropdownSpacer => "$dropdown-spacer",
            DropdownVariables.DropdownFontSize => "$dropdown-font-size",
            DropdownVariables.DropdownColor => "$dropdown-color",
            DropdownVariables.DropdownBg => "$dropdown-bg",
            DropdownVariables.DropdownBorderColor => "$dropdown-border-color",
            DropdownVariables.DropdownBorderRadius => "$dropdown-border-radius",
            DropdownVariables.DropdownBorderWidth => "$dropdown-border-width",
            DropdownVariables.DropdownInnerBorderRadius => "$dropdown-inner-border-radius",
            DropdownVariables.DropdownDividerBg => "$dropdown-divider-bg",
            DropdownVariables.DropdownDividerMarginY => "$dropdown-divider-margin-y",
            DropdownVariables.DropdownBoxShadow => "$dropdown-box-shadow",
            DropdownVariables.DropdownLinkColor => "$dropdown-link-color",
            DropdownVariables.DropdownLinkHoverColor => "$dropdown-link-hover-color",
            DropdownVariables.DropdownLinkHoverBg => "$dropdown-link-hover-bg",
            DropdownVariables.DropdownLinkActiveColor => "$dropdown-link-active-color",
            DropdownVariables.DropdownLinkActiveBg => "$dropdown-link-active-bg",
            DropdownVariables.DropdownLinkDisabledColor => "$dropdown-link-disabled-color",
            DropdownVariables.DropdownItemPaddingY => "$dropdown-item-padding-y",
            DropdownVariables.DropdownItemPaddingX => "$dropdown-item-padding-x",
            DropdownVariables.DropdownHeaderColor => "$dropdown-header-color",
            DropdownVariables.DropdownHeaderPaddingX => "$dropdown-header-padding-x",
            DropdownVariables.DropdownHeaderPaddingY => "$dropdown-header-padding-y",
            DropdownVariables.DropdownHeaderPadding => "$dropdown-header-padding",
            _ => ""
        };
    }
}
