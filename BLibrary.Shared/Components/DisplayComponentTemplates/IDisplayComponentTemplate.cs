using Blibrary.Shared.Models;

using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Components.DisplayComponentTemplates;

internal interface IDisplayComponentTemplate
{

    public List<ScssVariable> ColorSection { get; set; }

    public List<ScssVariable> SelectedColors { get; set; }

    public EventCallback<List<ScssVariable>> SelectedColorsChanged { get; set; }
    List<ScssVariableSection> Variables { get; set; }
}
