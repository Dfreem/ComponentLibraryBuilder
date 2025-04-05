namespace Blibrary.Shared.Enums.Generated;
public static class CardVariablesExtensions
{
    public static string ToSass(this CardVariables variable)
    {
        return variable switch
        {
            CardVariables.CardSpacerY => "$card-spacer-y",
            CardVariables.CardSpacerX => "$card-spacer-x",
            CardVariables.CardTitleSpacerY => "$card-title-spacer-y",
            CardVariables.CardTitleColor => "$card-title-color",
            CardVariables.CardSubtitleColor => "$card-subtitle-color",
            CardVariables.CardBorderWidth => "$card-border-width",
            CardVariables.CardBorderColor => "$card-border-color",
            CardVariables.CardBorderRadius => "$card-border-radius",
            CardVariables.CardBoxShadow => "$card-box-shadow",
            CardVariables.CardInnerBorderRadius => "$card-inner-border-radius",
            CardVariables.CardCapPaddingY => "$card-cap-padding-y",
            CardVariables.CardCapPaddingX => "$card-cap-padding-x",
            CardVariables.CardCapBg => "$card-cap-bg",
            CardVariables.CardCapColor => "$card-cap-color",
            CardVariables.CardHeight => "$card-height",
            CardVariables.CardColor => "$card-color",
            CardVariables.CardBg => "$card-bg",
            CardVariables.CardImgOverlayPadding => "$card-img-overlay-padding",
            CardVariables.CardGroupMargin => "$card-group-margin",
            _ => ""
        };
    }
}
