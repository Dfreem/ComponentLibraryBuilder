namespace Blibrary.Shared.Enums.Generated;
public static class ColorVariablesExtensions
{
    public static string ToSass(this ColorVariables variable)
    {
        return variable switch
        {
            ColorVariables.Blue => "$blue",
            ColorVariables.Indigo => "$indigo",
            ColorVariables.Purple => "$purple",
            ColorVariables.Pink => "$pink",
            ColorVariables.Red => "$red",
            ColorVariables.Orange => "$orange",
            ColorVariables.Yellow => "$yellow",
            ColorVariables.Green => "$green",
            ColorVariables.Teal => "$teal",
            ColorVariables.Cyan => "$cyan",
            _ => ""
        };
    }
}
