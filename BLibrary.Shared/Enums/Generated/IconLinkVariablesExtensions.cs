namespace Blibrary.Shared.Enums.Generated;
public static class IconLinkVariablesExtensions
{
    public static string ToSass(this IconLinkVariables variable)
    {
        return variable switch
        {
            IconLinkVariables.IconLinkGap => "$icon-link-gap",
            IconLinkVariables.IconLinkUnderlineOffset => "$icon-link-underline-offset",
            IconLinkVariables.IconLinkIconSize => "$icon-link-icon-size",
            IconLinkVariables.IconLinkIconTransition => "$icon-link-icon-transition",
            IconLinkVariables.IconLinkIconTransform => "$icon-link-icon-transform",
            _ => ""
        };
    }
}
