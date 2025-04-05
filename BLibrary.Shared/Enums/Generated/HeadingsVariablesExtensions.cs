namespace Blibrary.Shared.Enums.Generated;
public static class HeadingsVariablesExtensions
{
    public static string ToSass(this HeadingsVariables variable)
    {
        return variable switch
        {
            HeadingsVariables.HeadingsMarginBottom => "$headings-margin-bottom",
            HeadingsVariables.HeadingsFontFamily => "$headings-font-family",
            HeadingsVariables.HeadingsFontStyle => "$headings-font-style",
            HeadingsVariables.HeadingsFontWeight => "$headings-font-weight",
            HeadingsVariables.HeadingsLineHeight => "$headings-line-height",
            HeadingsVariables.HeadingsColor => "$headings-color",
            _ => ""
        };
    }
}
