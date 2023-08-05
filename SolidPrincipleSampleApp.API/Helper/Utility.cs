namespace SolidPrincipleSampleApp.API.Helper
{
    public class Utility
    {
        public static int[] getRangeNumbers(int min, int max)
        {
            return Enumerable.Range(min, max).ToArray();
        }
    }
}
