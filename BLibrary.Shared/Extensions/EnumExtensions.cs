using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Blibrary.Shared.Enums;

namespace Blibrary.Shared.Extensions;

public static class EnumExtensions
{
    public static string UnKabobify(this string kabob)
    {
        string[] bobs = kabob.Split('-');
        string result = "";
        Console.WriteLine(kabob);
        for (int i = 0; i < bobs.Length; i++)
        {
            string bob = bobs[i];
            bob = string.Concat(bob[0].ToString().ToUpper(), bob.AsSpan(1));
            result += bob;
        }
        return result;
    }

    public static string KabobToTitleCase(this string kabob)
    {
        var words = kabob.Trim().Split('-', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if(words.Length <= 1)
            return words[0]??"";
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = $"{char.ToUpper(words[i][0])}{words[i][1..]}";
        }
        return string.Join(" ", words);
    }

    public static string Kabobify<T>(this T value) where T : struct, Enum
    {
        var stringValue = Enum.GetName(value);
        for (int i = 0; i < stringValue?.Length; i++)
        {
            if (char.IsUpper(stringValue[i]))
            {
                if (i == 0)
                {
                    stringValue = stringValue.Remove(i, 1).Insert(i, char.ToLower(stringValue[i]).ToString());
                }
                else
                {
                    stringValue = stringValue.Remove(i, 1).Insert(i, $"-{char.ToLower(stringValue[i])}");
                }
            }
        }
        return stringValue ?? "";
    }

    public static string Kabobify(this string value)
    {

        for (int i = 0; i < value?.Length; i++)
        {
            if (char.IsUpper(value[i]))
            {
                if (i == 0)
                {
                    value = value.Remove(i, 1).Insert(i, char.ToLower(value[i]).ToString());
                }
                else
                {
                    value = value.Remove(i, 1).Insert(i, $"-{char.ToLower(value[i])}");
                }
            }
        }
        return value ?? "";
    }

    public static string GetInputType<T>(this T enumValue) where T : struct, Enum
    {
        // Get the enum name as a string
        string enumName = Enum.GetName(enumValue) ?? "";

        // If the enum name contains 'bg' or 'color', set the input type to 'color'
        // Otherwise, determine the input type based on the specific type
        return enumValue switch
        {
            var _ when enumName.Contains("bg") && !enumName.Contains("image") ||
                enumName.Contains("color") => "color",
            var _ when enumName.Contains("show") || enumName.Contains("enable") => "checkbox",
            var _ when enumName.Contains("width") || enumName.Contains("height") || enumName.Contains("padding") || enumName.Contains("margin") || enumName.Contains("z-index") || enumName.Contains("spacing") => "number",
            _ => "text"
        };
    }
    public static string GetInputType(this string enumName)
    {

        // If the name contains 'bg' or 'color', set the input type to 'color'
        // Otherwise, determine the input type based on the specific type
        return enumName switch
        {
            var _ when enumName.Contains("bg") && !enumName.Contains("image") ||
                enumName.Contains("color") => "color",
            var _ when enumName.Contains("show") || enumName.Contains("enable") => "checkbox",
            var _ when enumName.Contains("width") || enumName.Contains("height") || enumName.Contains("padding") || enumName.Contains("margin") || enumName.Contains("z-index") || enumName.Contains("spacing") => "range",
            _ => "text"
        };
    }
}
