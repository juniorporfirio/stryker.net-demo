using System.Globalization;
namespace StrykerDemo.Code
{
    public class FizzBuzz
    {
        public string Calculate(int number)
        {
            if(number > 500)
                return "C&IT";

            if((number % 5) == 0 && (number % 3) == 0)
                return "FizzBuzz";

            if((number % 3) == 0)
                return "Fizz";
            
            if((number% 5) == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}