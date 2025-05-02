using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Enums.UI;
public enum IconVendor
{
    Default,
    FontAwesome,
    FontAwesomeLight,
    FontAwesomeSolid,
    Bootstrap
}

public static class IconVendorExtensions
{
    public static string Prefix(this IconVendor vendor)
    {
        return vendor switch
        {
            IconVendor.FontAwesome => "fa",
            IconVendor.FontAwesomeLight => "fal",
            IconVendor.FontAwesomeSolid => "fas",
            _ => "bi"
        };
    }
}
