namespace Blibrary.Shared.Enums.Generated;
public static class BadgeVariablesExtensions
{
    public static string ToSass(this BadgeVariables variable)
    {
        return variable switch
        {
            BadgeVariables.BadgeFontSize => "$badge-font-size",
            BadgeVariables.BadgeFontWeight => "$badge-font-weight",
            BadgeVariables.BadgeColor => "$badge-color",
            BadgeVariables.BadgePaddingY => "$badge-padding-y",
            BadgeVariables.BadgePaddingX => "$badge-padding-x",
            BadgeVariables.BadgeBorderRadius => "$badge-border-radius",
            _ => ""
        };
    }
}
