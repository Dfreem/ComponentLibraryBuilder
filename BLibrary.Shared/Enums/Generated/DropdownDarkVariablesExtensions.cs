namespace Blibrary.Shared.Enums.Generated;
public static class DropdownDarkVariablesExtensions
{
    public static string ToSass(this DropdownDarkVariables variable)
    {
        return variable switch
        {
            DropdownDarkVariables.DropdownDarkColor => "$dropdown-dark-color",
            DropdownDarkVariables.DropdownDarkBg => "$dropdown-dark-bg",
            DropdownDarkVariables.DropdownDarkBorderColor => "$dropdown-dark-border-color",
            DropdownDarkVariables.DropdownDarkDividerBg => "$dropdown-dark-divider-bg",
            DropdownDarkVariables.DropdownDarkBoxShadow => "$dropdown-dark-box-shadow",
            DropdownDarkVariables.DropdownDarkLinkColor => "$dropdown-dark-link-color",
            DropdownDarkVariables.DropdownDarkLinkHoverColor => "$dropdown-dark-link-hover-color",
            DropdownDarkVariables.DropdownDarkLinkHoverBg => "$dropdown-dark-link-hover-bg",
            DropdownDarkVariables.DropdownDarkLinkActiveColor => "$dropdown-dark-link-active-color",
            DropdownDarkVariables.DropdownDarkLinkActiveBg => "$dropdown-dark-link-active-bg",
            DropdownDarkVariables.DropdownDarkLinkDisabledColor => "$dropdown-dark-link-disabled-color",
            DropdownDarkVariables.DropdownDarkHeaderColor => "$dropdown-dark-header-color",
            _ => ""
        };
    }
}
