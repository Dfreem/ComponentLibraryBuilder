using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Enums.UI;
public enum IconSet
{
    Default,
    FontAwesome,
    FontAwesomeLight,
    FontAwesomeSolid,
    Bootstrap
}

public static class IconVendorExtensions
{
    public static string Prefix(this IconSet vendor)
    {
        return vendor switch
        {
            IconSet.FontAwesome => "fa",
            IconSet.FontAwesomeLight => "fal",
            IconSet.FontAwesomeSolid => "fas",
            _ => "bi"
        };
    }
}
