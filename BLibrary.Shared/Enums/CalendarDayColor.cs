using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Enums;


[Flags]
public enum CalendarDayColor
{
    None = 0,
    Green = 1,
    Red = 2,
    Blue = 4,
    Selected = 8
}

public static class CalendarDayExtensions
{
    public static string ToCss(this CalendarDayColor colors)
    {
        string selected = "";
        if (colors.HasFlag(CalendarDayColor.Selected))
        {
            selected = "\noutline: 2px solid var(--calendar-selected-border);background-color: var(--calendar-selected-color);";
        }
        var colorArray = colors.ToString()
            .Replace("None", "")
            .Replace("Selected", "")
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        int numColors = colorArray.Length;
        var result = numColors switch
        {
            1 => $"background-color: {colorArray[0].ToLower()};",
            2 => $"background: conic-gradient(from 45deg, {colorArray[0]} 180deg, {colorArray[1]} 180deg 360deg);",
            3 => $"background: conic-gradient({colorArray[0]} 120deg, {colorArray[1]} 120deg 240deg, {colorArray[2]} 240deg 360deg);",
            4 => $"background: conic-gradient(from 45deg, {colorArray[0]} 90deg, {colorArray[1]} 90deg 180deg, {colorArray[2]} 180deg 340deg, {colorArray[3]} 340deg 360deg);",
            _ => ""
        };
        result += selected;
        return result;
    }
}
