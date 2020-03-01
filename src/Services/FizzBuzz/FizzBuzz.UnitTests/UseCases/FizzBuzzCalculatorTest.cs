using FizzBuzz.App.UseCases;
using FizzBuzz.App.UseCases.Interfaces;
using FluentAssertions;
using Xunit;

namespace FizzBuzz.UnitTests.UseCases
{
    public class FizzBuzzCalculatorTest
    {
        private readonly IFizzBuzzCalculator fizzBuzzCalculator;

        public FizzBuzzCalculatorTest()
        {
            fizzBuzzCalculator = new FizzBuzzCalculator();
        }

        [Theory]
        [InlineData(1,"1")]
        public void Calculate_should_return_correct_string(int entry, string expected)
        {
            fizzBuzzCalculator.Calculate(entry).Should().Be(expected);
        }

    }
}
