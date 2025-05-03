using Blibrary.Shared.Enums.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Components.Icon;
public interface IIcon<TIcon> where TIcon : struct, Enum
{
    IconSet IconSet { get; set; }

    string CSS { get; set; }
}
