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
