namespace Blibrary.Shared.Enums.Generated;
public static class CollapseTransitionExtensions
{
    public static string ToSass(this CollapseTransition variable)
    {
        return variable switch
        {
            CollapseTransition.TransitionCollapse => "$transition-collapse",
            CollapseTransition.TransitionCollapseWidth => "$transition-collapse-width",
            _ => ""
        };
    }
}
