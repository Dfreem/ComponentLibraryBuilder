namespace Blibrary.Shared.Enums.Generated;
public static class FontVariablesExtensions
{
    public static string ToSass(this FontVariables variable)
    {
        return variable switch
        {
            FontVariables.FontFamilySansSerif => "$font-family-sans-serif",
            FontVariables.FontFamilyMonospace => "$font-family-monospace",
            FontVariables.FontFamilyBase => "$font-family-base",
            FontVariables.FontFamilyCode => "$font-family-code",
            FontVariables.FontSizeRoot => "$font-size-root",
            FontVariables.FontSizeBase => "$font-size-base",
            FontVariables.FontSizeSm => "$font-size-sm",
            FontVariables.FontSizeLg => "$font-size-lg",
            FontVariables.FontWeightLighter => "$font-weight-lighter",
            FontVariables.FontWeightLight => "$font-weight-light",
            FontVariables.FontWeightNormal => "$font-weight-normal",
            FontVariables.FontWeightMedium => "$font-weight-medium",
            FontVariables.FontWeightSemibold => "$font-weight-semibold",
            FontVariables.FontWeightBold => "$font-weight-bold",
            FontVariables.FontWeightBolder => "$font-weight-bolder",
            FontVariables.FontWeightBase => "$font-weight-base",
            FontVariables.LineHeightBase => "$line-height-base",
            FontVariables.LineHeightSm => "$line-height-sm",
            FontVariables.LineHeightLg => "$line-height-lg",
            FontVariables.H1FontSize => "$h1-font-size",
            FontVariables.H2FontSize => "$h2-font-size",
            FontVariables.H3FontSize => "$h3-font-size",
            FontVariables.H4FontSize => "$h4-font-size",
            FontVariables.H5FontSize => "$h5-font-size",
            FontVariables.H6FontSize => "$h6-font-size",
            _ => ""
        };
    }
}
