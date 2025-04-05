namespace Blibrary.Shared.Enums.Generated;
public static class CaretVariablesExtensions
{
    public static string ToSass(this CaretVariables variable)
    {
        return variable switch
        {
            CaretVariables.CaretWidth => "$caret-width",
            CaretVariables.CaretVerticalAlign => "$caret-vertical-align",
            CaretVariables.CaretSpacing => "$caret-spacing",
            _ => ""
        };
    }
}
