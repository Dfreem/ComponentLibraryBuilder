using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Enums;

/// <summary>
/// Bootstrap Modal style specific variables
/// </summary>
public enum ModalVariable
{
    None,
    ModalBackdropBg,
    ModalBackdropOpacity,
    ModalBorderWidth,
    ModalContentBg,
    ModalContentBorderColor,
    ModalContentBorderRadius,
    ModalContentBorderWidth,
    ModalContentBoxShadowSmUp,
    ModalContentBoxShadowXs,
    ModalContentColor,
    ModalContentInnerBorderRadius,
    ModalDialogMargin,
    ModalFadeTransform,
    ModalFooterBg,
    ModalBorderColor,
    ModalFooterMarginBetween,
    ModalHeaderPaddingX,
    ModalHeaderPaddingY,
    ModalHeaderPadding = ModalHeaderPaddingX | ModalHeaderPaddingY,
    ModalInnerPadding,
    ModalLg,
    ModalMd,
    ModalScaleTransform,
    ModalShowTransform,
    ModalSm,
    ModalTitleLineHeight,
    ModalTransition,
    ModalXl,
}
public static class ModalVariableExtension
{

    /// <summary>
    /// Converts Modal Component specifc style enum to a <see cref="ScssVariableType"/> enum.
    /// The ScssVariableType is helpful for determining what kind of value is acceptable to pair the orginal variable with.
    /// </summary>
    /// <param name="variable">a modal styles specific variable used to define custom styling for a Modal Component</param>
    /// <returns>the scss type that the variable should accept</returns>
    public static ScssVariableType GetVariableType(this ModalVariable variable)
    {
        return variable switch
        {
            ModalVariable.ModalBackdropBg or ModalVariable.ModalContentBg or ModalVariable.ModalFooterBg or ModalVariable.ModalContentBorderColor or ModalVariable.ModalContentColor or ModalVariable.ModalBorderColor => ScssVariableType.Color,
            ModalVariable.ModalBackdropOpacity => ScssVariableType.BinaryRange,
            ModalVariable.ModalDialogMargin or ModalVariable.ModalHeaderPadding or ModalVariable.ModalInnerPadding or ModalVariable.ModalFooterMarginBetween or ModalVariable.ModalTitleLineHeight or ModalVariable.ModalContentBorderRadius or ModalVariable.ModalContentInnerBorderRadius or ModalVariable.ModalContentBoxShadowXs or ModalVariable.ModalContentBoxShadowSmUp => ScssVariableType.Size,
            ModalVariable.ModalLg or ModalVariable.ModalMd or ModalVariable.ModalSm or ModalVariable.ModalXl or ModalVariable.ModalContentBorderWidth or ModalVariable.ModalBorderWidth => ScssVariableType.Width,
            ModalVariable.ModalShowTransform => ScssVariableType.Bool,
            ModalVariable.ModalTransition or ModalVariable.ModalScaleTransform or ModalVariable.ModalFadeTransform => ScssVariableType.Str,
            _ => ScssVariableType.None,
        };
    }

    /// <summary>
    /// a string that can be used directly in a html/razor input element as the value for the `type` attribute.
    /// </summary>
    /// <param name="tVar"></param>
    /// <returns>the value that should be used as the type attribute in an input element</returns>
    public static string InputType(this ScssVariableType tVar)
    {
        return tVar switch
        {
            ScssVariableType.Color => "color",
            ScssVariableType.BinaryRange or ScssVariableType.ZIndex or ScssVariableType.Height or ScssVariableType.Width or ScssVariableType.Size => "number",
            ScssVariableType.Bool => "checkbox",
            ScssVariableType.Str => "text",
            _ => ""
        };
    }

    /// <summary>
    /// Converts enum representation of Bootstrap Modal styles specific variables into their dollar sign pre-fixed scss variable names used to customize bootstrap style generation<see cref="ModalVariable"/>
    /// </summary>
    /// <param name="variable"></param>
    /// <returns></returns>
    public static string ToSass(this ModalVariable variable)
    {
        return variable switch
        {
            ModalVariable.ModalInnerPadding => "$modal-inner-padding",
            ModalVariable.ModalFooterMarginBetween => "$modal-footer-margin-between",
            ModalVariable.ModalDialogMargin => "$modal-dialog-margin",
            ModalVariable.ModalTitleLineHeight => "$modal-title-line-height",
            ModalVariable.ModalContentColor => "$modal-content-color",
            ModalVariable.ModalContentBg => "$modal-content-bg",
            ModalVariable.ModalBorderColor or ModalVariable.ModalContentBorderColor => "$modal-content-border-color",
            ModalVariable.ModalContentBorderWidth => "$modal-content-border-width",
            ModalVariable.ModalContentBorderRadius => "$modal-content-border-radius",
            ModalVariable.ModalContentInnerBorderRadius => "$modal-content-inner-border-radius",
            ModalVariable.ModalContentBoxShadowXs => "$modal-content-box-shadow-xs",
            ModalVariable.ModalContentBoxShadowSmUp => "$modal-content-box-shadow-sm-up",
            ModalVariable.ModalBackdropBg => "$modal-backdrop-bg",
            ModalVariable.ModalBackdropOpacity => "$modal-backdrop-opacity",
            ModalVariable.ModalHeaderPaddingX => "$modal-header-padding-x",
            ModalVariable.ModalHeaderPaddingY => "$modal-header-padding-y",
            ModalVariable.ModalFooterBg => "$modal-footer-bg",
            ModalVariable.ModalSm => "$modal-sm",
            ModalVariable.ModalMd => "$modal-md",
            ModalVariable.ModalLg => "$modal-lg",
            ModalVariable.ModalXl => "$modal-xl",
            ModalVariable.ModalFadeTransform => "$modal-fade-transform",
            ModalVariable.ModalShowTransform => "$modal-show-transform",
            ModalVariable.ModalTransition => "$modal-transition",
            ModalVariable.ModalScaleTransform => "$modal-scale-transform",
            ModalVariable.ModalBorderWidth => "$modal-content-border-width",
            _ => "",
        };
    }

    // TODO create base class and method for scss variable extensions.
    /// <summary>
    /// Converts Bootstrap Modal specific scss variable names in kabob case, into an enum representation of the variable.
    /// </summary>
    /// <param name="sass"></param>
    /// <returns></returns>
    public static ModalVariable ToModalVariable(this string sass)
    {
        return sass switch
        {
            "$modal-inner-padding" or "modal-inner-padding" => ModalVariable.ModalInnerPadding,
            "$modal-footer-margin-between" or "modal-footer-margin-between" => ModalVariable.ModalFooterMarginBetween,
            "$modal-dialog-margin" or "modal-dialog-margin" => ModalVariable.ModalDialogMargin,
            "$modal-title-line-height" or "modal-title-line-height" => ModalVariable.ModalTitleLineHeight,
            "$modal-content-color" or "modal-content-color" => ModalVariable.ModalContentColor,
            "$modal-content-bg" or "modal-content-bg" => ModalVariable.ModalContentBg,
            "$modal-content-border-color" or "modal-header-border-color" or "modal-content-border-color" => ModalVariable.ModalBorderColor,
            "$modal-content-border-radius" or "modal-content-border-radius" => ModalVariable.ModalContentBorderRadius,
            "$modal-content-inner-border-radius" or "modal-content-inner-border-radius" => ModalVariable.ModalContentInnerBorderRadius,
            "$modal-content-box-shadow-xs" or "modal-content-box-shadow-xs" => ModalVariable.ModalContentBoxShadowXs,
            "$modal-content-box-shadow-sm-up" or "modal-content-box-shadow-sm-up" => ModalVariable.ModalContentBoxShadowSmUp,
            "$modal-backdrop-bg" or "modal-backdrop-bg" => ModalVariable.ModalBackdropBg,
            "$modal-backdrop-opacity" or "modal-backdrop-opacity" => ModalVariable.ModalBackdropOpacity,
            "$modal-header-padding" => ModalVariable.ModalHeaderPadding, 
            "modal-header-padding-x" => ModalVariable.ModalHeaderPaddingX, 
            "modal-header-padding-y" => ModalVariable.ModalHeaderPaddingY,
            "$modal-footer-bg" or "modal-footer-bg" => ModalVariable.ModalFooterBg,
            "$modal-sm" or "modal-sm" => ModalVariable.ModalSm,
            "$modal-md" or "modal-md" => ModalVariable.ModalMd,
            "$modal-lg" or "modal-lg" => ModalVariable.ModalLg,
            "$modal-xl" or "modal-xl" => ModalVariable.ModalXl,
            "$modal-fade-transform" or "modal-fade-transform" => ModalVariable.ModalFadeTransform,
            "$modal-show-transform" or "modal-show-transform" => ModalVariable.ModalShowTransform,
            "$modal-transition" or "modal-transition" => ModalVariable.ModalTransition,
            "$modal-scale-transform" or "modal-scale-transform" => ModalVariable.ModalScaleTransform,
            "$modal-content-border-width" or"modal-header-border-width" or "modal-content-border-width" => ModalVariable.ModalBorderWidth,
            _ => ModalVariable.None,
        };
    }
}
