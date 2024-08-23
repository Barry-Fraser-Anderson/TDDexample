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
        [Fact]

        public void Calculator_Negative_ThrowsException()
        {
            var calculator = new Calculator();
            Action action1 = () => calculator.Add("-1,2");
            action1.Should().Throw<Exception>().WithMessage("Negatives not allowed: -1");
            Action action2 = () => calculator.Add("2,-4,3,-5");
            action2.Should().Throw<Exception>().WithMessage("Negatives not allowed: -4,-5");
        }
        
        [Fact]
        public void Calculator_Over1000_Ignored()
        {
            var calculator = new Calculator();
            var result = calculator.Add("1001,2");

            result.Should().Be(2);
        }
    }
}