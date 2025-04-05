namespace Blibrary.Shared.Enums.Generated;
public static class TypeVariablesExtensions
{
    public static string ToSass(this TypeVariables variable)
    {
        return variable switch
        {
            TypeVariables.LeadFontSize => "$lead-font-size",
            TypeVariables.LeadFontWeight => "$lead-font-weight",
            TypeVariables.SmallFontSize => "$small-font-size",
            TypeVariables.SubSupFontSize => "$sub-sup-font-size",
            TypeVariables.TextMuted => "$text-muted",
            TypeVariables.InitialismFontSize => "$initialism-font-size",
            TypeVariables.BlockquoteMarginY => "$blockquote-margin-y",
            TypeVariables.BlockquoteFontSize => "$blockquote-font-size",
            TypeVariables.BlockquoteFooterColor => "$blockquote-footer-color",
            TypeVariables.BlockquoteFooterFontSize => "$blockquote-footer-font-size",
            TypeVariables.HrMarginY => "$hr-margin-y",
            TypeVariables.HrColor => "$hr-color",
            TypeVariables.HrBgColor => "$hr-bg-color",
            TypeVariables.HrHeight => "$hr-height",
            TypeVariables.HrBorderColor => "$hr-border-color",
            TypeVariables.HrBorderWidth => "$hr-border-width",
            TypeVariables.HrOpacity => "$hr-opacity",
            TypeVariables.VrBorderWidth => "$vr-border-width",
            _ => ""
        };
    }
}
