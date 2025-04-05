namespace Blibrary.Shared.Enums.Generated;
public static class CarouselDarkVariablesExtensions
{
    public static string ToSass(this CarouselDarkVariables variable)
    {
        return variable switch
        {
            CarouselDarkVariables.CarouselDarkIndicatorActiveBg => "$carousel-dark-indicator-active-bg",
            CarouselDarkVariables.CarouselDarkCaptionColor => "$carousel-dark-caption-color",
            CarouselDarkVariables.CarouselDarkControlIconFilter => "$carousel-dark-control-icon-filter",
            _ => ""
        };
    }
}
