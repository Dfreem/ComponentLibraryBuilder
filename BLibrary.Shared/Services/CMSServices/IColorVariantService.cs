using Blibrary.Shared.Models;

namespace Blibrary.Shared.Services.CMSServices
{
    public interface IColorVariantService
    {
        List<ScssVariable> ColorSection { get; set; }
        ScssVariableSection CurrentSection { get; set; }

        event EventHandler<ColorEventArgs>? OnSelectionChanged;

        void SelectColor(string colorKey);
        void UnSelectColor(string colorKey);

        void SelectColor(ScssVariable colorKey);
        void UnSelectColor(ScssVariable colorKey);
        void SwitchComponent(string sectionTitle);
    }
}