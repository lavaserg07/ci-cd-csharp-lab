using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddReturnCorrectSum()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(3, 4);
            Assert.Equal(7, result);

        }
    }
}