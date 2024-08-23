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

        [Fact]
        public void Calculator_OneNumber_ReturnInt()
        {
            var calculator = new Calculator();
            var result = calculator.Add("10");

            result.Should().Be(10);
        }

        [Fact]
        public void Calculator_TwoNumber_ReturnInt()
        {
            var calculator = new Calculator();
            var result = calculator.Add("12,13");

            result.Should().Be(25);
        }

        [Fact]
        public void Calculator_MultipleNumber_ReturnInt()
        {
            var calculator = new Calculator();
            var result = calculator.Add("1,2,3,4,5,6,7,8,9,100");

            result.Should().Be(145);
        }

        [Fact]
        public void Calculator_NewLines_ReturnInt()
        {
            var calculator = new Calculator();
            var result = calculator.Add("1\n2,3,4,5,6\n7,8,9,100");

            result.Should().Be(145);
        }
        [Fact]
        public void Calculator_NewDelim_ReturnInt()
        {
            var calculator = new Calculator();
            var result = calculator.Add("//;\n1\n2;3;4;5;6\n7;8;9;100");

            result.Should().Be(145);
        }
    }
}