namespace Blibrary.Shared.Enums.Generated;
public static class PlaceholdersExtensions
{
    public static string ToSass(this Placeholders variable)
    {
        return variable switch
        {
            Placeholders.PlaceholderOpacityMax => "$placeholder-opacity-max",
            Placeholders.PlaceholderOpacityMin => "$placeholder-opacity-min",
            _ => ""
        };
    }
}
