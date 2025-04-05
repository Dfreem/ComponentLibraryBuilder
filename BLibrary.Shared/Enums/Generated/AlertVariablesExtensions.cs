namespace Blibrary.Shared.Enums.Generated;
public static class AlertVariablesExtensions
{
    public static string ToSass(this AlertVariables variable)
    {
        return variable switch
        {
            AlertVariables.AlertPaddingY => "$alert-padding-y",
            AlertVariables.AlertPaddingX => "$alert-padding-x",
            AlertVariables.AlertMarginBottom => "$alert-margin-bottom",
            AlertVariables.AlertBorderRadius => "$alert-border-radius",
            AlertVariables.AlertLinkFontWeight => "$alert-link-font-weight",
            AlertVariables.AlertBorderWidth => "$alert-border-width",
            AlertVariables.AlertDismissiblePaddingR => "$alert-dismissible-padding-r",
            _ => ""
        };
    }
}
