namespace FizzBuzzProject.Repository
{
    public class DivisionService:IDivision
    {
        public string GetFizzBuzzResult(int number)
        {
            int result1;
            int result2;


            if (number == 23)
            {
                 result1 = number / 3;
                 result2 = number / 5;
                return $"{number}/3 = {result1} and {number}/5 = {result2}";
            }
            else if (number == 1)
            {
                result1 = number / 3;
                result2 = number / 5;
                return $"{number}/3 = {result1} and {number}/5 = {result2}";
            }
            else if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return $"Invalid Item";
        }

    }
}
