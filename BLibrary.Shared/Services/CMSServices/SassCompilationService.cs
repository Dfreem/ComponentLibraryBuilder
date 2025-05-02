using Blibrary.Shared.DTO;
using Blibrary.Shared.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Services.CMSServices;

public class SassCompilationService : ISassCompilationService
{
    public List<ScssVariable> ColorSection { get; set; } = [];

    public List<ScssVariable> SelectedColors { get; set; } = [];

    public Dictionary<string, string> PrimaryColorMap { get; set; } = new()
    {
        ["primary"] = "#0d6efd",
        ["secondary"] = "#6c757d",
        ["success"] = "#198754",
        ["info"] = "#0dcaf0",
        ["warning"] = "#ffc107",
        ["danger"] = "#dc3545",
    };

    private List<string> _variantSections { get; set; } = [];

    public event EventHandler<ColorEventArgs>? OnSelectionChanged;

    public event EventHandler<SassCompilationArgs>? OnEnableDisableCompilation;

    public void EnableDisableCompilationFor(string sectionTitle)
    {
        bool compile = true;
        if (!_variantSections.Remove(sectionTitle))
        {
            _variantSections.Add(sectionTitle);
            compile = false;
        }
        OnEnableDisableCompilation?.Invoke(this, new() { Compile = compile, SectionTitle = sectionTitle });
    }

    public void SelectColor(string colorKey)
    {
        var color = ColorSection.FirstOrDefault(c => c.Key == colorKey);
        if (color == null)
            return;
        SelectColor(color);
    }

    public void SelectColor(ScssVariable color)
    {
        if (SelectedColors.Any(c => c.Key == color.Key))
            return;
        SelectedColors.Add(color);
        OnSelectionChanged?.Invoke(this, new() { Colors = SelectedColors });
    }

    public void UnSelectColor(string colorKey)
    {
        var color = ColorSection.FirstOrDefault(c => c.Key == colorKey);
        if (color == null)
            return;
        UnSelectColor(color);
    }

    public void UnSelectColor(ScssVariable color)
    {
        SelectedColors.Remove(color);
        OnSelectionChanged?.Invoke(this, new() { Colors = SelectedColors });
    }

    public void SelectAllColors()
    {
        SelectedColors = ColorSection.GetRange(0, ColorSection.Count);
        OnSelectionChanged?.Invoke(this, new() { Colors = SelectedColors });
    }

    public void UnselectAllColors()
    {
        SelectedColors.Clear();
        OnSelectionChanged?.Invoke(this, new() { Colors = SelectedColors });
    }
}
