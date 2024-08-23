using FluentAssertions;
using System.ComponentModel;
using Domain;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void Calculator_EmptyString_ReturnZero()
        {
            var calculator = new Calculator();
            var result = calculator.Add("");

            result.Should().Be(0); 
        }
   }
}