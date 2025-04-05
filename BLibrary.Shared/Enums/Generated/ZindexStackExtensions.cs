namespace Blibrary.Shared.Enums.Generated;
public static class ZindexStackExtensions
{
    public static string ToSass(this ZindexStack variable)
    {
        return variable switch
        {
            ZindexStack.ZindexDropdown => "$zindex-dropdown",
            ZindexStack.ZindexSticky => "$zindex-sticky",
            ZindexStack.ZindexFixed => "$zindex-fixed",
            ZindexStack.ZindexOffcanvasBackdrop => "$zindex-offcanvas-backdrop",
            ZindexStack.ZindexOffcanvas => "$zindex-offcanvas",
            ZindexStack.ZindexModalBackdrop => "$zindex-modal-backdrop",
            ZindexStack.ZindexModal => "$zindex-modal",
            ZindexStack.ZindexPopover => "$zindex-popover",
            ZindexStack.ZindexTooltip => "$zindex-tooltip",
            ZindexStack.ZindexToast => "$zindex-toast",
            _ => ""
        };
    }
}
