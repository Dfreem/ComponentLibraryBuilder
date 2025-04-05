namespace Blibrary.Shared.Enums.Generated;
public static class NavbarVariablesExtensions
{
    public static string ToSass(this NavbarVariables variable)
    {
        return variable switch
        {
            NavbarVariables.NavbarPaddingY => "$navbar-padding-y",
            NavbarVariables.NavbarPaddingX => "$navbar-padding-x",
            NavbarVariables.NavbarNavLinkPaddingX => "$navbar-nav-link-padding-x",
            NavbarVariables.NavbarBrandFontSize => "$navbar-brand-font-size",
            NavbarVariables.NavLinkHeight => "$nav-link-height",
            NavbarVariables.NavbarBrandHeight => "$navbar-brand-height",
            NavbarVariables.NavbarBrandPaddingY => "$navbar-brand-padding-y",
            NavbarVariables.NavbarBrandMarginEnd => "$navbar-brand-margin-end",
            NavbarVariables.NavbarTogglerPaddingY => "$navbar-toggler-padding-y",
            NavbarVariables.NavbarTogglerPaddingX => "$navbar-toggler-padding-x",
            NavbarVariables.NavbarTogglerFontSize => "$navbar-toggler-font-size",
            NavbarVariables.NavbarTogglerBorderRadius => "$navbar-toggler-border-radius",
            NavbarVariables.NavbarTogglerFocusWidth => "$navbar-toggler-focus-width",
            NavbarVariables.NavbarTogglerTransition => "$navbar-toggler-transition",
            NavbarVariables.NavbarLightColor => "$navbar-light-color",
            NavbarVariables.NavbarLightHoverColor => "$navbar-light-hover-color",
            NavbarVariables.NavbarLightActiveColor => "$navbar-light-active-color",
            NavbarVariables.NavbarLightDisabledColor => "$navbar-light-disabled-color",
            NavbarVariables.NavbarLightIconColor => "$navbar-light-icon-color",
            NavbarVariables.NavbarLightTogglerIconBg => "$navbar-light-toggler-icon-bg",
            NavbarVariables.NavbarLightTogglerBorderColor => "$navbar-light-toggler-border-color",
            NavbarVariables.NavbarLightBrandColor => "$navbar-light-brand-color",
            NavbarVariables.NavbarLightBrandHoverColor => "$navbar-light-brand-hover-color",
            _ => ""
        };
    }
}
