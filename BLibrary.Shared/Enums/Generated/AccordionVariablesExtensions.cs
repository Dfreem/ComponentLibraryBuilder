namespace Blibrary.Shared.Enums.Generated;
public static class AccordionVariablesExtensions
{
    public static string ToSass(this AccordionVariables variable)
    {
        return variable switch
        {
            AccordionVariables.AccordionPaddingY => "$accordion-padding-y",
            AccordionVariables.AccordionPaddingX => "$accordion-padding-x",
            AccordionVariables.AccordionColor => "$accordion-color",
            AccordionVariables.AccordionBg => "$accordion-bg",
            AccordionVariables.AccordionBorderWidth => "$accordion-border-width",
            AccordionVariables.AccordionBorderColor => "$accordion-border-color",
            AccordionVariables.AccordionBorderRadius => "$accordion-border-radius",
            AccordionVariables.AccordionInnerBorderRadius => "$accordion-inner-border-radius",
            AccordionVariables.AccordionBodyPaddingY => "$accordion-body-padding-y",
            AccordionVariables.AccordionBodyPaddingX => "$accordion-body-padding-x",
            AccordionVariables.AccordionButtonPaddingY => "$accordion-button-padding-y",
            AccordionVariables.AccordionButtonPaddingX => "$accordion-button-padding-x",
            AccordionVariables.AccordionButtonColor => "$accordion-button-color",
            AccordionVariables.AccordionButtonBg => "$accordion-button-bg",
            AccordionVariables.AccordionTransition => "$accordion-transition",
            AccordionVariables.AccordionButtonActiveBg => "$accordion-button-active-bg",
            AccordionVariables.AccordionButtonActiveColor => "$accordion-button-active-color",
            AccordionVariables.AccordionButtonFocusBorderColor => "$accordion-button-focus-border-color",
            AccordionVariables.AccordionButtonFocusBoxShadow => "$accordion-button-focus-box-shadow",
            AccordionVariables.AccordionIconWidth => "$accordion-icon-width",
            AccordionVariables.AccordionIconColor => "$accordion-icon-color",
            AccordionVariables.AccordionIconActiveColor => "$accordion-icon-active-color",
            AccordionVariables.AccordionIconTransition => "$accordion-icon-transition",
            AccordionVariables.AccordionIconTransform => "$accordion-icon-transform",
            AccordionVariables.AccordionButtonIcon => "$accordion-button-icon",
            AccordionVariables.AccordionButtonActiveIcon => "$accordion-button-active-icon",
            _ => ""
        };
    }
}
