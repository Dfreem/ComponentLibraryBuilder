namespace Blibrary.Shared.Enums.Generated;
public static class FigureVariablesExtensions
{
    public static string ToSass(this FigureVariables variable)
    {
        return variable switch
        {
            FigureVariables.FigureCaptionFontSize => "$figure-caption-font-size",
            FigureVariables.FigureCaptionColor => "$figure-caption-color",
            _ => ""
        };
    }
}
