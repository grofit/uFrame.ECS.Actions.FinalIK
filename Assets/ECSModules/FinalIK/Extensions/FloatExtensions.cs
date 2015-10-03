namespace Assets.ECSModules.FinalIK.Extensions
{
    public static class FloatExtensions
    {
        public static bool IsNotZero(this float value)
        { return value > 0.0f || value < 0.0f; }
    }
}
