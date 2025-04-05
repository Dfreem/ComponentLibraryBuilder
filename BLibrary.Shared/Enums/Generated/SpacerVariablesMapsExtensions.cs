namespace Blibrary.Shared.Enums.Generated;
public static class SpacerVariablesMapsExtensions
{
    public static string ToSass(this SpacerVariablesMaps variable)
    {
        return variable switch
        {
            SpacerVariablesMaps.Spacer => "$spacer",
            _ => ""
        };
    }
}
