using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.TextTemplates.Runtime;

public partial class SassCompiler
{
    public string? SassContent { get; set; }

	public SassCompiler(string? sassContent)
	{
		SassContent = sassContent;
	}
}
