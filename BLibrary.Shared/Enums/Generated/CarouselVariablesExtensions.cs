namespace Blibrary.Shared.Enums.Generated;
public static class CarouselVariablesExtensions
{
    public static string ToSass(this CarouselVariables variable)
    {
        return variable switch
        {
            CarouselVariables.CarouselControlColor => "$carousel-control-color",
            CarouselVariables.CarouselControlWidth => "$carousel-control-width",
            CarouselVariables.CarouselControlOpacity => "$carousel-control-opacity",
            CarouselVariables.CarouselControlHoverOpacity => "$carousel-control-hover-opacity",
            CarouselVariables.CarouselControlTransition => "$carousel-control-transition",
            CarouselVariables.CarouselIndicatorWidth => "$carousel-indicator-width",
            CarouselVariables.CarouselIndicatorHeight => "$carousel-indicator-height",
            CarouselVariables.CarouselIndicatorHitAreaHeight => "$carousel-indicator-hit-area-height",
            CarouselVariables.CarouselIndicatorSpacer => "$carousel-indicator-spacer",
            CarouselVariables.CarouselIndicatorOpacity => "$carousel-indicator-opacity",
            CarouselVariables.CarouselIndicatorActiveBg => "$carousel-indicator-active-bg",
            CarouselVariables.CarouselIndicatorActiveOpacity => "$carousel-indicator-active-opacity",
            CarouselVariables.CarouselIndicatorTransition => "$carousel-indicator-transition",
            CarouselVariables.CarouselCaptionWidth => "$carousel-caption-width",
            CarouselVariables.CarouselCaptionColor => "$carousel-caption-color",
            CarouselVariables.CarouselCaptionPaddingY => "$carousel-caption-padding-y",
            CarouselVariables.CarouselCaptionSpacer => "$carousel-caption-spacer",
            CarouselVariables.CarouselControlIconWidth => "$carousel-control-icon-width",
            CarouselVariables.CarouselControlPrevIconBg => "$carousel-control-prev-icon-bg",
            CarouselVariables.CarouselControlNextIconBg => "$carousel-control-next-icon-bg",
            CarouselVariables.CarouselTransitionDuration => "$carousel-transition-duration",
            CarouselVariables.CarouselTransition => "$carousel-transition",
            _ => ""
        };
    }
}
