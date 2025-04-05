namespace Blibrary.Shared.Enums.Generated;
public static class DisplayHeadingsExtensions
{
    public static string ToSass(this DisplayHeadings variable)
    {
        return variable switch
        {
            DisplayHeadings.DisplayFontFamily => "$display-font-family",
            DisplayHeadings.DisplayFontStyle => "$display-font-style",
            DisplayHeadings.DisplayFontWeight => "$display-font-weight",
            DisplayHeadings.DisplayLineHeight => "$display-line-height",
            _ => ""
        };
    }
}
