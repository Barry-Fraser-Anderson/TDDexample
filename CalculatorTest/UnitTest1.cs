using FluentAssertions;
using System.ComponentModel;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void Calculator_EmptyString_ReturnZero()
        {
            var result = Add("");

            result.Should().Be(0); 
        }

        int Add(string value)
        {
            throw new NotImplementedException();
        }
    }
}