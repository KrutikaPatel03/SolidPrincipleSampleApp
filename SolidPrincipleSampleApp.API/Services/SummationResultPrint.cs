using SolidPrincipleSampleApp.API.Services.Interfaces;

namespace SolidPrincipleSampleApp.API.Services
{
    //Single Responsibility Principle(SRP) - this handle printing result
    //Open/Closed Principle(OCP) - we can add more summation methods without changing its definition
    //Dependency Inversion Principle (DIP) - this class depends on the abstraction ISummationMethod
    public class SummationResultPrint
    {
        private readonly ISummationMethod _summationMethod;

        public SummationResultPrint(ISummationMethod summationMethod)
        {
            _summationMethod = summationMethod;
        }

        public string Print(int[] numbers)
        {
            long sum = _summationMethod.Sum(numbers);
            var msg = $"The sum of {numbers.Max()} integers = {sum}";
            Console.WriteLine(msg);
            return msg ;
        }
    }
}
