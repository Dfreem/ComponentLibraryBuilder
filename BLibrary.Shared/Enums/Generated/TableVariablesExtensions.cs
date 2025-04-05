namespace Blibrary.Shared.Enums.Generated;
public static class TableVariablesExtensions
{
    public static string ToSass(this TableVariables variable)
    {
        return variable switch
        {
            TableVariables.TableCellPaddingY => "$table-cell-padding-y",
            TableVariables.TableCellPaddingX => "$table-cell-padding-x",
            TableVariables.TableCellPaddingYSm => "$table-cell-padding-y-sm",
            TableVariables.TableCellPaddingXSm => "$table-cell-padding-x-sm",
            TableVariables.TableCellVerticalAlign => "$table-cell-vertical-align",
            TableVariables.TableColor => "$table-color",
            TableVariables.TableBg => "$table-bg",
            TableVariables.TableAccentBg => "$table-accent-bg",
            TableVariables.TableThFontWeight => "$table-th-font-weight",
            TableVariables.TableStripedColor => "$table-striped-color",
            TableVariables.TableStripedBgFactor => "$table-striped-bg-factor",
            TableVariables.TableStripedBg => "$table-striped-bg",
            TableVariables.TableActiveColor => "$table-active-color",
            TableVariables.TableActiveBgFactor => "$table-active-bg-factor",
            TableVariables.TableActiveBg => "$table-active-bg",
            TableVariables.TableHoverColor => "$table-hover-color",
            TableVariables.TableHoverBgFactor => "$table-hover-bg-factor",
            TableVariables.TableHoverBg => "$table-hover-bg",
            TableVariables.TableBorderFactor => "$table-border-factor",
            TableVariables.TableBorderWidth => "$table-border-width",
            TableVariables.TableBorderColor => "$table-border-color",
            TableVariables.TableStripedOrder => "$table-striped-order",
            TableVariables.TableStripedColumnsOrder => "$table-striped-columns-order",
            TableVariables.TableGroupSeparatorColor => "$table-group-separator-color",
            TableVariables.TableCaptionColor => "$table-caption-color",
            TableVariables.TableBgScale => "$table-bg-scale",
            _ => ""
        };
    }
}
