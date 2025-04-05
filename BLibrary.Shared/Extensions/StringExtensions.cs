using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Extensions;
public static class StringExtensions
{
    /// <summary>
    /// a better ToString that works for many different types
    /// </summary>
    /// <param name="entity">the object to display as a string</param>
    /// <returns>the object as a string</returns>
    public static string AsString(this object entity)
    {

        StringBuilder sb = new();
        foreach (System.Reflection.PropertyInfo property in entity.GetType().GetProperties())
        {
            sb.Append(property.Name);
            sb.Append(": ");
            if (property.GetIndexParameters().Length > 0)
            {
                sb.Append("Indexed Property cannot be used");
            }
            else
            {
                sb.Append(property.GetValue(entity, null));
            }

            sb.Append(Environment.NewLine);
        }

        return sb.ToString();
    }

    public static string AsString<T>(this IEnumerable<T> entities)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"=========== List<{typeof(T)}> ========== ");
        foreach (var item in entities)
        {
            builder.AppendLine(item?.AsString());
        }
        return builder.ToString();
    }
}
