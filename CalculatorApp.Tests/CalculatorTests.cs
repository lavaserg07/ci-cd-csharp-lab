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
            int Result = calc.Add(3, 4);
            Assert.Equal(5, Result);

        }
    }
}