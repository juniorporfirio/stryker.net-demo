using StrykerDemo.Code;
using Shouldly;
using Xunit;

namespace StrykerDemo.Teste
{
    public class FizzBuzzTeste
    {

        [Fact]
        public void Should_Return_Fizz_Number_Multiple_Of_Three()
        {
            var fizzbuzz = new FizzBuzz();

            var result = fizzbuzz.Calculate(3);

            result.ShouldBe("Fizz");
        }

        [Fact]
        public void Should_Return_Buzz_Number_Multiple_Of_Five()
        {
            var fizzbuzz = new FizzBuzz();

            var result = fizzbuzz.Calculate(5);

            result.ShouldBe("Buzz");
        }

         [Fact]
        public void Should_Print_Number_Case_Number_Not_Be_Multiple_Of_Three_And_Five()
        {
            var fizzbuzz = new FizzBuzz();

            var result = fizzbuzz.Calculate(1);

            result.ShouldBe("1");
        }

        [Fact]
        public void Should_Return_Buzz_Number_Multiple_Of_Three_And_Five()
        {
            var fizzbuzz = new FizzBuzz();

            var result = fizzbuzz.Calculate(15);

            result.ShouldBe("FizzBuzz");
        }

        [Fact]
        public void Should_Return_CIT_Number_Greater_Than_Five_Hundred()
        {
            var fizzbuzz = new FizzBuzz();

            var result = fizzbuzz.Calculate(501);

            result.ShouldBe("C&IT");
        }
    }
}