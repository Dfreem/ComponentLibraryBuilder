using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Enums.UI;

[Flags]
public enum ToastLocation
{
    None = 0,
    Top = 1,
    Right = 2,
    Bottom = 4,
    Left = 8,
    Center = 16
}

public static class ToastLocationExtensions
{
    public static string ToCssClass(this ToastLocation location)
    {
        if(location == ToastLocation.None)
            location = ToastLocation.Top | ToastLocation.Center; // default to top center
        string result = location.ToString().ToLower();
        string[] results = result.Split(',');
        result = results.Aggregate((a, b) =>
        {
            return a + " " + b + " ";
        });
        return result;
    }
}
