using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Enums;
public enum ScssVariableType
{
    None,
    Color,
    Width,
    Height,
    Size,
    ZIndex,
    Bool,
    BinaryRange,
    Str
}

public enum ScssSizeUnit
{
    None,
    Percent,
    EM,
    REM,
    PX,
    VW,
    VH,
    CQW,
    CQH
}

public static class SizeUnit
{
    public static string ToCssUnit(this ScssSizeUnit unit)
    {
        if (unit == ScssSizeUnit.Percent)
            return "%";
        return Enum.GetName(unit)?.ToLower() ?? "px";

    }

    public static string ToCssUnit(this string unit)
    {
        ScssSizeUnit sizeUnit = Enum.Parse<ScssSizeUnit>(unit);
        if (sizeUnit == ScssSizeUnit.Percent)
            return "%";
        return Enum.GetName(sizeUnit)?.ToLower() ?? "px";

    }

    public static List<string> GetCssUnits<T>() where T : Enum
    {
        List<string> results = [];
        foreach (var item in Enum.GetValues<ScssSizeUnit>())
        {
            results.Add(item.ToCssUnit());
        }
        return results;
    }

}
