namespace Blibrary.Shared.Enums.Generated;
public static class GrayColorVariablesExtensions
{
    public static string ToSass(this GrayColorVariables variable)
    {
        return variable switch
        {
            GrayColorVariables.White => "$white",
            GrayColorVariables.Gray100 => "$gray100",
            GrayColorVariables.Gray200 => "$gray200",
            GrayColorVariables.Gray300 => "$gray300",
            GrayColorVariables.Gray400 => "$gray400",
            GrayColorVariables.Gray500 => "$gray500",
            GrayColorVariables.Gray600 => "$gray600",
            GrayColorVariables.Gray700 => "$gray700",
            GrayColorVariables.Gray800 => "$gray800",
            GrayColorVariables.Gray900 => "$gray900",
            GrayColorVariables.Black => "$black",
            _ => ""
        };
    }
}
