namespace Blibrary.Shared.Enums.Generated;
public static class NavbarDarkVariablesExtensions
{
    public static string ToSass(this NavbarDarkVariables variable)
    {
        return variable switch
        {
            NavbarDarkVariables.NavbarDarkColor => "$navbar-dark-color",
            NavbarDarkVariables.NavbarDarkHoverColor => "$navbar-dark-hover-color",
            NavbarDarkVariables.NavbarDarkActiveColor => "$navbar-dark-active-color",
            NavbarDarkVariables.NavbarDarkDisabledColor => "$navbar-dark-disabled-color",
            NavbarDarkVariables.NavbarDarkIconColor => "$navbar-dark-icon-color",
            NavbarDarkVariables.NavbarDarkTogglerIconBg => "$navbar-dark-toggler-icon-bg",
            NavbarDarkVariables.NavbarDarkTogglerBorderColor => "$navbar-dark-toggler-border-color",
            NavbarDarkVariables.NavbarDarkBrandColor => "$navbar-dark-brand-color",
            NavbarDarkVariables.NavbarDarkBrandHoverColor => "$navbar-dark-brand-hover-color",
            _ => ""
        };
    }
}
