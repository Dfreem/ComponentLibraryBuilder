namespace Blibrary.Shared.Enums.Generated;
public static class ModalVariablesExtensions
{
    public static string ToSass(this ModalVariables variable)
    {
        return variable switch
        {
            ModalVariables.ModalInnerPadding => "$modal-inner-padding",
            ModalVariables.ModalFooterMarginBetween => "$modal-footer-margin-between",
            ModalVariables.ModalDialogMargin => "$modal-dialog-margin",
            ModalVariables.ModalDialogMarginYSmUp => "$modal-dialog-margin-y-sm-up",
            ModalVariables.ModalTitleLineHeight => "$modal-title-line-height",
            ModalVariables.ModalContentColor => "$modal-content-color",
            ModalVariables.ModalContentBg => "$modal-content-bg",
            ModalVariables.ModalContentBorderColor => "$modal-content-border-color",
            ModalVariables.ModalContentBorderWidth => "$modal-content-border-width",
            ModalVariables.ModalContentBorderRadius => "$modal-content-border-radius",
            ModalVariables.ModalContentInnerBorderRadius => "$modal-content-inner-border-radius",
            ModalVariables.ModalContentBoxShadowXs => "$modal-content-box-shadow-xs",
            ModalVariables.ModalContentBoxShadowSmUp => "$modal-content-box-shadow-sm-up",
            ModalVariables.ModalBackdropBg => "$modal-backdrop-bg",
            ModalVariables.ModalBackdropOpacity => "$modal-backdrop-opacity",
            ModalVariables.ModalHeaderBorderColor => "$modal-header-border-color",
            ModalVariables.ModalHeaderBorderWidth => "$modal-header-border-width",
            ModalVariables.ModalHeaderPaddingY => "$modal-header-padding-y",
            ModalVariables.ModalHeaderPaddingX => "$modal-header-padding-x",
            ModalVariables.ModalHeaderPadding => "$modal-header-padding",
            ModalVariables.ModalFooterBg => "$modal-footer-bg",
            ModalVariables.ModalFooterBorderColor => "$modal-footer-border-color",
            ModalVariables.ModalFooterBorderWidth => "$modal-footer-border-width",
            ModalVariables.ModalSm => "$modal-sm",
            ModalVariables.ModalMd => "$modal-md",
            ModalVariables.ModalLg => "$modal-lg",
            ModalVariables.ModalXl => "$modal-xl",
            ModalVariables.ModalFadeTransform => "$modal-fade-transform",
            ModalVariables.ModalShowTransform => "$modal-show-transform",
            ModalVariables.ModalTransition => "$modal-transition",
            ModalVariables.ModalScaleTransform => "$modal-scale-transform",
            _ => ""
        };
    }
}
