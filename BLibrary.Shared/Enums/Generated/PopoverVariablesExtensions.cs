namespace Blibrary.Shared.Enums.Generated;
public static class PopoverVariablesExtensions
{
    public static string ToSass(this PopoverVariables variable)
    {
        return variable switch
        {
            PopoverVariables.PopoverFontSize => "$popover-font-size",
            PopoverVariables.PopoverBg => "$popover-bg",
            PopoverVariables.PopoverMaxWidth => "$popover-max-width",
            PopoverVariables.PopoverBorderWidth => "$popover-border-width",
            PopoverVariables.PopoverBorderColor => "$popover-border-color",
            PopoverVariables.PopoverBorderRadius => "$popover-border-radius",
            PopoverVariables.PopoverInnerBorderRadius => "$popover-inner-border-radius",
            PopoverVariables.PopoverBoxShadow => "$popover-box-shadow",
            PopoverVariables.PopoverHeaderFontSize => "$popover-header-font-size",
            PopoverVariables.PopoverHeaderBg => "$popover-header-bg",
            PopoverVariables.PopoverHeaderColor => "$popover-header-color",
            PopoverVariables.PopoverHeaderPaddingY => "$popover-header-padding-y",
            PopoverVariables.PopoverHeaderPaddingX => "$popover-header-padding-x",
            PopoverVariables.PopoverBodyColor => "$popover-body-color",
            PopoverVariables.PopoverBodyPaddingY => "$popover-body-padding-y",
            PopoverVariables.PopoverBodyPaddingX => "$popover-body-padding-x",
            PopoverVariables.PopoverArrowWidth => "$popover-arrow-width",
            PopoverVariables.PopoverArrowHeight => "$popover-arrow-height",
            _ => ""
        };
    }
}
