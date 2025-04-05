namespace Blibrary.Shared.Enums.Generated;
public static class ListGroupVariablesExtensions
{
    public static string ToSass(this ListGroupVariables variable)
    {
        return variable switch
        {
            ListGroupVariables.ListGroupColor => "$list-group-color",
            ListGroupVariables.ListGroupBg => "$list-group-bg",
            ListGroupVariables.ListGroupBorderColor => "$list-group-border-color",
            ListGroupVariables.ListGroupBorderWidth => "$list-group-border-width",
            ListGroupVariables.ListGroupBorderRadius => "$list-group-border-radius",
            ListGroupVariables.ListGroupItemPaddingY => "$list-group-item-padding-y",
            ListGroupVariables.ListGroupItemPaddingX => "$list-group-item-padding-x",
            ListGroupVariables.ListGroupItemBgScale => "$list-group-item-bg-scale",
            ListGroupVariables.ListGroupItemColorScale => "$list-group-item-color-scale",
            ListGroupVariables.ListGroupHoverBg => "$list-group-hover-bg",
            ListGroupVariables.ListGroupActiveColor => "$list-group-active-color",
            ListGroupVariables.ListGroupActiveBg => "$list-group-active-bg",
            ListGroupVariables.ListGroupActiveBorderColor => "$list-group-active-border-color",
            ListGroupVariables.ListGroupDisabledColor => "$list-group-disabled-color",
            ListGroupVariables.ListGroupDisabledBg => "$list-group-disabled-bg",
            ListGroupVariables.ListGroupActionColor => "$list-group-action-color",
            ListGroupVariables.ListGroupActionHoverColor => "$list-group-action-hover-color",
            ListGroupVariables.ListGroupActionActiveColor => "$list-group-action-active-color",
            ListGroupVariables.ListGroupActionActiveBg => "$list-group-action-active-bg",
            _ => ""
        };
    }
}
