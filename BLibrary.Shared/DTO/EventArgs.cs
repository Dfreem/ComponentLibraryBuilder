using Blibrary.Shared.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.DTO;

public class ModalEventArgs : EventArgs
{
    public string Id { get; set; } = "";
    public bool Show { get; set; }
}
public class ColorEventArgs : EventArgs
{
    public List<ScssVariable> Colors { get; set; } = [];
}

public class SassCompilationArgs : EventArgs
{
    public string SectionTitle { get; set; } = "";
    public bool Compile { get; set; }
}

