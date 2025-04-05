namespace Blibrary.Shared.Enums.Generated;
public static class CloseVariablesExtensions
{
    public static string ToSass(this CloseVariables variable)
    {
        return variable switch
        {
            CloseVariables.BtnCloseWidth => "$btn-close-width",
            CloseVariables.BtnCloseHeight => "$btn-close-height",
            CloseVariables.BtnClosePaddingX => "$btn-close-padding-x",
            CloseVariables.BtnClosePaddingY => "$btn-close-padding-y",
            CloseVariables.BtnCloseColor => "$btn-close-color",
            CloseVariables.BtnCloseBg => "$btn-close-bg",
            CloseVariables.BtnCloseFocusShadow => "$btn-close-focus-shadow",
            CloseVariables.BtnCloseOpacity => "$btn-close-opacity",
            CloseVariables.BtnCloseHoverOpacity => "$btn-close-hover-opacity",
            CloseVariables.BtnCloseFocusOpacity => "$btn-close-focus-opacity",
            CloseVariables.BtnCloseDisabledOpacity => "$btn-close-disabled-opacity",
            CloseVariables.BtnCloseWhiteFilter => "$btn-close-white-filter",
            _ => ""
        };
    }
}
