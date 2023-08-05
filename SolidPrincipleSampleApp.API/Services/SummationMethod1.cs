using SolidPrincipleSampleApp.API.Services.Interfaces;

namespace SolidPrincipleSampleApp.API.Services
{
    public class SummationMethod1 : ISummationMethod
    {
        public long Sum(int[] numbers)
        {
            return numbers.Select(q => Convert.ToInt64(q)).Sum();
        }
    }
}

