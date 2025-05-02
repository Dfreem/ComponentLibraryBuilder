
using Blibrary.Shared.Extensions;

using System.Text;

namespace Blibrary.Shared.Enums.Style;

public enum Display
{
    Block,
    Inline,
    InlineBlock,
    Flex,
    InlineFlex
}

public static class DisplayExtensions
{
    public static string ToCss(this Display display)
    {
        string result = "d-";
        result += display.Kabobify();
        return result;
    }
}
