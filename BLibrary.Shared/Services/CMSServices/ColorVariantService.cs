using Blibrary.Shared.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibrary.Shared.Services.CMSServices;

public class ColorVariantService : IColorVariantService
{
    public List<ScssVariable> ColorSection { get; set; } = [];

    private ScssVariableSection _currentSection = new();

    public ScssVariableSection CurrentSection
    {
        get
        {
            return _currentSection;
        }
        set
        {
            _currentSection = value;
        }
    }
    public string CurrentSectionTitle { get; set; } = "";

    public event EventHandler<ColorEventArgs>? OnSelectionChanged;

    public void SwitchComponent(string sectionTitle)
    {
        ScssVariable[] holder = [];
        CurrentSection.ColorVariations.CopyTo(holder);
        CurrentSectionTitle = sectionTitle;
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
        if (CurrentSection.ColorVariations.Any(c => c.Key == color.Key))
            return;
        CurrentSection.ColorVariations.Add(color);
        OnSelectionChanged?.Invoke(this, new() { Colors = CurrentSection.ColorVariations });
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
        CurrentSection.ColorVariations.Remove(color);
        OnSelectionChanged?.Invoke(this, new() { Colors = CurrentSection.ColorVariations });
    }
}

public class ColorEventArgs : EventArgs
{
    public List<ScssVariable> Colors { get; set; } = [];
}
