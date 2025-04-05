using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Enums;

public enum BootstrapColor
{
    Default,
    Danger,
    Success,
    Warning,
    Primary,
    Secondary,
    Light,
    Dark,
    White,
    Black
}

public static class BootstrapExtensions
{
    public static string ToTextColor(this BootstrapColor color)
    {

        return color switch
        {
            BootstrapColor.Danger => "text-danger",
            BootstrapColor.Success => "text-success",
            BootstrapColor.Warning => "text-warning",
            BootstrapColor.Primary => "text-primary",
            BootstrapColor.Secondary => "text-secondary",
            BootstrapColor.Light => "text-light",
            BootstrapColor.Dark => "text-dark",
            BootstrapColor.White => "text-white",
            BootstrapColor.Black => "text-black",
            BootstrapColor.Default => "text-black",
            _ => "",
        };
    }

    public static string ToLinkColor(this BootstrapColor color)
    {

        return color switch
        {
            BootstrapColor.Danger => "link-danger",
            BootstrapColor.Success => "link-success",
            BootstrapColor.Warning => "link-warning",
            BootstrapColor.Primary => "link-primary",
            BootstrapColor.Secondary => "link-secondary",
            BootstrapColor.Light => "link-light",
            BootstrapColor.Dark => "link-dark",
            BootstrapColor.White => "link-white",
            BootstrapColor.Black => "link-black",
            BootstrapColor.Default => "link-black",
            _ => "",
        };
    }

    public static string ToButtonColor(this BootstrapColor color)
    {
        return color switch
        {
            BootstrapColor.Black => "btn-black",
            BootstrapColor.White => "btn-white",
            BootstrapColor.Dark => "btn-dark",
            BootstrapColor.Light => "btn-light",
            BootstrapColor.Danger => "btn-danger",
            BootstrapColor.Success => "btn-success",
            BootstrapColor.Warning => "btn-warning",
            BootstrapColor.Primary => "btn-primary",
            BootstrapColor.Secondary => "btn-secondary",
            _ => "",
        };
    }

    public static string ToBgColor(this BootstrapColor color)
    {
        return color switch
        {
            BootstrapColor.Black => "bg-black",
            BootstrapColor.White => "bg-white",
            BootstrapColor.Dark => "bg-dark",
            BootstrapColor.Light => "bg-light",
            BootstrapColor.Danger => "bg-danger",
            BootstrapColor.Success => "bg-success",
            BootstrapColor.Warning => "bg-warning",
            BootstrapColor.Primary => "bg-primary",
            BootstrapColor.Secondary => "bg-secondary",
            _ => "",
        };
    }
}
