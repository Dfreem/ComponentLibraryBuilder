namespace Blibrary.Shared.Enums.Generated;
public static class NavVariablesExtensions
{
    public static string ToSass(this NavVariables variable)
    {
        return variable switch
        {
            NavVariables.NavLinkPaddingY => "$nav-link-padding-y",
            NavVariables.NavLinkPaddingX => "$nav-link-padding-x",
            NavVariables.NavLinkFontSize => "$nav-link-font-size",
            NavVariables.NavLinkFontWeight => "$nav-link-font-weight",
            NavVariables.NavLinkColor => "$nav-link-color",
            NavVariables.NavLinkHoverColor => "$nav-link-hover-color",
            NavVariables.NavLinkTransition => "$nav-link-transition",
            NavVariables.NavLinkDisabledColor => "$nav-link-disabled-color",
            NavVariables.NavLinkFocusBoxShadow => "$nav-link-focus-box-shadow",
            NavVariables.NavTabsBorderColor => "$nav-tabs-border-color",
            NavVariables.NavTabsBorderWidth => "$nav-tabs-border-width",
            NavVariables.NavTabsBorderRadius => "$nav-tabs-border-radius",
            NavVariables.NavTabsLinkHoverBorderColor => "$nav-tabs-link-hover-border-color",
            NavVariables.NavTabsLinkActiveColor => "$nav-tabs-link-active-color",
            NavVariables.NavTabsLinkActiveBg => "$nav-tabs-link-active-bg",
            NavVariables.NavTabsLinkActiveBorderColor => "$nav-tabs-link-active-border-color",
            NavVariables.NavPillsBorderRadius => "$nav-pills-border-radius",
            NavVariables.NavPillsLinkActiveColor => "$nav-pills-link-active-color",
            NavVariables.NavPillsLinkActiveBg => "$nav-pills-link-active-bg",
            NavVariables.NavUnderlineGap => "$nav-underline-gap",
            NavVariables.NavUnderlineBorderWidth => "$nav-underline-border-width",
            NavVariables.NavUnderlineLinkActiveColor => "$nav-underline-link-active-color",
            _ => ""
        };
    }
}
