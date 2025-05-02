using Blibrary.Shared.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Enums.Style;

public enum BootstrapColor
{
    Default,
    Danger,
    Success,
    Warning,
    Primary,
    PrimaryLight,
    Secondary,
    SecondaryLight,
    Light,
    Dark,
    White,
    Black,
    Grey100,
    Grey200,
    Grey300,
    Grey400,
    Grey500,
    Grey600,
    Grey700,
    Grey800,
    Grey900,
}

public static class BootstrapExtensions
{
    public static string ToTextColor(this BootstrapColor color)
    {
        return "text-" + color.Kabobify();
    }

    public static string ToLinkColor(this BootstrapColor color)
    {
        return "link-" + color.Kabobify();
        //return color switch
        //{
        //    BootstrapColor.Danger => "link-danger",
        //    BootstrapColor.Success => "link-success",
        //    BootstrapColor.Warning => "link-warning",
        //    BootstrapColor.Primary => "link-primary",
        //    BootstrapColor.Secondary => "link-secondary",
        //    BootstrapColor.Light => "link-light",
        //    BootstrapColor.Dark => "link-dark",
        //    BootstrapColor.White => "link-white",
        //    BootstrapColor.Black => "link-black",
        //    BootstrapColor.Default => "link-black",
        //    _ => "",
        //};
    }

    public static string ToButtonColor(this BootstrapColor color)
    {
        return "btn-" + color.Kabobify();
    }

    public static string ToBgColor(this BootstrapColor color)
    {
        if (color == BootstrapColor.Default)
            color = BootstrapColor.Grey100;
        return "bg-" + color.Kabobify();
        //return color switch
        //{
        //    BootstrapColor.Black => "bg-black",
        //    BootstrapColor.White => "bg-white",
        //    BootstrapColor.Dark => "bg-dark",
        //    BootstrapColor.Light => "bg-light",
        //    BootstrapColor.Danger => "bg-danger",
        //    BootstrapColor.Success => "bg-success",
        //    BootstrapColor.Warning => "bg-warning",
        //    BootstrapColor.Primary => "bg-primary",
        //    BootstrapColor.Secondary => "bg-secondary",
        //    _ => "",
        //};
    }
}
