using SolidPrincipleSampleApp.API.Services.Interfaces;
using System;

namespace SolidPrincipleSampleApp.API.Services
{
    public class SummationMethod2 : ISummationMethod
    {
        public long Sum(int[] numbers)
        {
            return numbers.AsParallel().Sum(x => (long)x);
        }
    }
}
