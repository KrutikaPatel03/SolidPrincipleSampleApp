namespace SolidPrincipleSampleApp.API.Services.Interfaces
{
    //Single Responsibility Principle(SRP) to handle calculation
    //Interface Segregation Principle (ISP) -This interface containes only necessary method
    //by implementation classes
    public interface ISummationMethod
    {
        long Sum(int[] numbers);
    }
}
