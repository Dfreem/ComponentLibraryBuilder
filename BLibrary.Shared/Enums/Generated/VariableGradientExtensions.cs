namespace Blibrary.Shared.Enums.Generated;
public static class VariableGradientExtensions
{
    public static string ToSass(this VariableGradient variable)
    {
        return variable switch
        {
            VariableGradient.Gradient => "$gradient",
            _ => ""
        };
    }
}
