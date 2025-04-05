namespace Blibrary.Shared.Enums.Generated;
public static class InputGroupVariablesExtensions
{
    public static string ToSass(this InputGroupVariables variable)
    {
        return variable switch
        {
            InputGroupVariables.InputGroupAddonPaddingY => "$input-group-addon-padding-y",
            InputGroupVariables.InputGroupAddonPaddingX => "$input-group-addon-padding-x",
            InputGroupVariables.InputGroupAddonFontWeight => "$input-group-addon-font-weight",
            InputGroupVariables.InputGroupAddonColor => "$input-group-addon-color",
            InputGroupVariables.InputGroupAddonBg => "$input-group-addon-bg",
            InputGroupVariables.InputGroupAddonBorderColor => "$input-group-addon-border-color",
            _ => ""
        };
    }
}
