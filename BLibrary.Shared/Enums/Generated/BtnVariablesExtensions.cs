namespace Blibrary.Shared.Enums.Generated;
public static class BtnVariablesExtensions
{
    public static string ToSass(this BtnVariables variable)
    {
        return variable switch
        {
            BtnVariables.BtnColor => "$btn-color",
            BtnVariables.BtnPaddingY => "$btn-padding-y",
            BtnVariables.BtnPaddingX => "$btn-padding-x",
            BtnVariables.BtnFontFamily => "$btn-font-family",
            BtnVariables.BtnFontSize => "$btn-font-size",
            BtnVariables.BtnLineHeight => "$btn-line-height",
            BtnVariables.BtnWhiteSpace => "$btn-white-space",
            BtnVariables.BtnPaddingYSm => "$btn-padding-y-sm",
            BtnVariables.BtnPaddingXSm => "$btn-padding-x-sm",
            BtnVariables.BtnFontSizeSm => "$btn-font-size-sm",
            BtnVariables.BtnPaddingYLg => "$btn-padding-y-lg",
            BtnVariables.BtnPaddingXLg => "$btn-padding-x-lg",
            BtnVariables.BtnFontSizeLg => "$btn-font-size-lg",
            BtnVariables.BtnBorderWidth => "$btn-border-width",
            BtnVariables.BtnFontWeight => "$btn-font-weight",
            BtnVariables.BtnBoxShadow => "$btn-box-shadow",
            BtnVariables.BtnFocusWidth => "$btn-focus-width",
            BtnVariables.BtnFocusBoxShadow => "$btn-focus-box-shadow",
            BtnVariables.BtnDisabledOpacity => "$btn-disabled-opacity",
            BtnVariables.BtnActiveBoxShadow => "$btn-active-box-shadow",
            BtnVariables.BtnLinkColor => "$btn-link-color",
            BtnVariables.BtnLinkHoverColor => "$btn-link-hover-color",
            BtnVariables.BtnLinkDisabledColor => "$btn-link-disabled-color",
            BtnVariables.BtnLinkFocusShadowRgb => "$btn-link-focus-shadow-rgb",
            BtnVariables.BtnBorderRadius => "$btn-border-radius",
            BtnVariables.BtnBorderRadiusSm => "$btn-border-radius-sm",
            BtnVariables.BtnBorderRadiusLg => "$btn-border-radius-lg",
            BtnVariables.BtnTransition => "$btn-transition",
            BtnVariables.BtnHoverBgShadeAmount => "$btn-hover-bg-shade-amount",
            BtnVariables.BtnHoverBgTintAmount => "$btn-hover-bg-tint-amount",
            BtnVariables.BtnHoverBorderShadeAmount => "$btn-hover-border-shade-amount",
            BtnVariables.BtnHoverBorderTintAmount => "$btn-hover-border-tint-amount",
            BtnVariables.BtnActiveBgShadeAmount => "$btn-active-bg-shade-amount",
            BtnVariables.BtnActiveBgTintAmount => "$btn-active-bg-tint-amount",
            BtnVariables.BtnActiveBorderShadeAmount => "$btn-active-border-shade-amount",
            BtnVariables.BtnActiveBorderTintAmount => "$btn-active-border-tint-amount",
            _ => ""
        };
    }
}
