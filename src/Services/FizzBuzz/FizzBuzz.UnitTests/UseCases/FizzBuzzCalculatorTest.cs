using FizzBuzz.App.UseCases;
using FizzBuzz.App.UseCases.Interfaces;

namespace FizzBuzz.UnitTests.UseCases
{
    public class FizzBuzzCalculatorTest
    {
        private readonly IFizzBuzzCalculator fizzBuzzCalculator;

        public FizzBuzzCalculatorTest()
        {
            fizzBuzzCalculator = new FizzBuzzCalculator();
        }
    }
}
