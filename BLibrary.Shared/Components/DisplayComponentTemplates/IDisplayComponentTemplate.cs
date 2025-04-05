using Blibrary.Shared.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Components.DisplayComponentTemplates;

internal interface IDisplayComponentTemplate
{
    List<ScssVariableSection> Variables { get; set; }
}
