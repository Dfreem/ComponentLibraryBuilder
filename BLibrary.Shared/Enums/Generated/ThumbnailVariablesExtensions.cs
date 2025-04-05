namespace Blibrary.Shared.Enums.Generated;
public static class ThumbnailVariablesExtensions
{
    public static string ToSass(this ThumbnailVariables variable)
    {
        return variable switch
        {
            ThumbnailVariables.ThumbnailPadding => "$thumbnail-padding",
            ThumbnailVariables.ThumbnailBg => "$thumbnail-bg",
            ThumbnailVariables.ThumbnailBorderWidth => "$thumbnail-border-width",
            ThumbnailVariables.ThumbnailBorderColor => "$thumbnail-border-color",
            ThumbnailVariables.ThumbnailBorderRadius => "$thumbnail-border-radius",
            ThumbnailVariables.ThumbnailBoxShadow => "$thumbnail-box-shadow",
            _ => ""
        };
    }
}
