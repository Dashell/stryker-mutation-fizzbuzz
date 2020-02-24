using FizzBuzz.App.UseCases;
using FizzBuzz.App.UseCases.Interfaces;
using System;
using System.Linq;

namespace FizzBuzz.App
{
    public class FizzBuzz
    {
        private readonly IFizzBuzzCalculator fizzBuzzCalculator;

        public FizzBuzz()
        {
            this.fizzBuzzCalculator = new FizzBuzzCalculator();
        }
        public void Execute()
        {
            foreach (int i in Enumerable.Range(0, 100))
            {
                Console.WriteLine(fizzBuzzCalculator.Calculate(i));
            }
        }
    }
}
