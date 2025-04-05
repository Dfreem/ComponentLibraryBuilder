namespace Blibrary.Shared.Enums.Generated;
public static class ToastVariablesExtensions
{
    public static string ToSass(this ToastVariables variable)
    {
        return variable switch
        {
            ToastVariables.ToastMaxWidth => "$toast-max-width",
            ToastVariables.ToastPaddingX => "$toast-padding-x",
            ToastVariables.ToastPaddingY => "$toast-padding-y",
            ToastVariables.ToastFontSize => "$toast-font-size",
            ToastVariables.ToastColor => "$toast-color",
            ToastVariables.ToastBackgroundColor => "$toast-background-color",
            ToastVariables.ToastBorderWidth => "$toast-border-width",
            ToastVariables.ToastBorderColor => "$toast-border-color",
            ToastVariables.ToastBorderRadius => "$toast-border-radius",
            ToastVariables.ToastBoxShadow => "$toast-box-shadow",
            ToastVariables.ToastSpacing => "$toast-spacing",
            ToastVariables.ToastHeaderColor => "$toast-header-color",
            ToastVariables.ToastHeaderBackgroundColor => "$toast-header-background-color",
            ToastVariables.ToastHeaderBorderColor => "$toast-header-border-color",
            _ => ""
        };
    }
}
