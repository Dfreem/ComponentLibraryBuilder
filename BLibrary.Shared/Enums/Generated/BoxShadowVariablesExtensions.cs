namespace Blibrary.Shared.Enums.Generated;
public static class BoxShadowVariablesExtensions
{
    public static string ToSass(this BoxShadowVariables variable)
    {
        return variable switch
        {
            BoxShadowVariables.BoxShadow => "$box-shadow",
            BoxShadowVariables.BoxShadowSm => "$box-shadow-sm",
            BoxShadowVariables.BoxShadowLg => "$box-shadow-lg",
            BoxShadowVariables.BoxShadowInset => "$box-shadow-inset",
            _ => ""
        };
    }
}
