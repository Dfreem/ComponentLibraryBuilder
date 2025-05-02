using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Enums.Icon;

/// <summary>
/// IconCollection species the sub-collection if available to choose the icon variant from. 
/// For example, Font Awesome has many variants for each icon, indicated by the prefix css class used, fal, fas & fa
/// </summary>
/// <example>
/// IconCollection.FontAwesomeLight.Prefix() -> "fal"
/// </example>
public enum IconCollection
{
    Default,
    FontAwesome,
    FontAwesomeLight,
    FontAwesomeSolid,
    Bootstrap
}

public static class IconCollectionExtensions
{
    public static string Prefix(this IconCollection vendor)
    {
        return vendor switch
        {
            IconCollection.FontAwesome => "fa",
            IconCollection.FontAwesomeLight => "fal",
            IconCollection.FontAwesomeSolid => "fas",
            _ => "bi"
        };
    }
}
