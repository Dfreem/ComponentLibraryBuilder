namespace Blibrary.Shared.Enums.Generated;
public static class BorderRadiusVariablesExtensions
{
    public static string ToSass(this BorderRadiusVariables variable)
    {
        return variable switch
        {
            BorderRadiusVariables.BorderRadius => "$border-radius",
            BorderRadiusVariables.BorderRadiusSm => "$border-radius-sm",
            BorderRadiusVariables.BorderRadiusLg => "$border-radius-lg",
            BorderRadiusVariables.BorderRadiusXl => "$border-radius-xl",
            BorderRadiusVariables.BorderRadiusXxl => "$border-radius-xxl",
            BorderRadiusVariables.BorderRadiusPill => "$border-radius-pill",
            _ => ""
        };
    }
}
