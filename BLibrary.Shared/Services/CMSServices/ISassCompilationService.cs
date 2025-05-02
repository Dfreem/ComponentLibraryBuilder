using Blibrary.Shared.DTO;
using Blibrary.Shared.Models;

namespace Blibrary.Shared.Services.CMSServices
{
    public interface ISassCompilationService
    {
        /// <summary>
        /// Get or set the extra color variants to include in bootstraps theme-colors map used to generate component variants. 
        /// Bootstrap will generate 10 different shades for each color included in this list.
        /// </summary>
        List<ScssVariable> SelectedColors { get; set; }
        /// <summary>
        /// All the colors
        /// </summary>
        List<ScssVariable> ColorSection { get; set; }
        /// <summary>
        /// A map for the primary bootstrap theme colors, primary, secondary and tertiary and component colors not controlled by color variants, EG: link color, shadow color, etc
        /// </summary>
        Dictionary<string, string> PrimaryColorMap { get; set; }

        event EventHandler<ColorEventArgs>? OnSelectionChanged;
        event EventHandler<SassCompilationArgs>? OnEnableDisableCompilation;

        void SelectAllColors();

        /// <summary>
        /// Remove or add a component section to the compilation
        /// </summary>
        /// <param name="sectionTitle"></param>
        void EnableDisableCompilationFor(string sectionTitle);

        /// <summary>
        /// Add a color to the theme color map used to compile component variants
        /// </summary>
        /// <param name="colorKey"></param>
        void SelectColor(string colorKey);
        /// <summary>
        /// Add a color to the theme color map used to compile component variants
        /// </summary>
        /// <param name="colorKey"></param>
        void SelectColor(ScssVariable color);
        /// <summary>
        /// Remove a color to the theme color map used to compile component variants
        /// </summary>
        /// <param name="colorKey"></param>
        void UnSelectColor(string colorKey);
        /// <summary>
        /// Remove a color to the theme color map used to compile component variants
        /// </summary>
        /// <param name="colorKey"></param>
        void UnSelectColor(ScssVariable color);
        void UnselectAllColors();
    }
}