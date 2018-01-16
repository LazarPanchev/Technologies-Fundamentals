namespace EnglishNameOfTheLastDigit
{
    using System;
    public class Program
    {
        public static void Main()
        {
            long inputNumber = long.Parse(Console.ReadLine());
            string  result = ReturnLastDigit(inputNumber);
            Console.WriteLine(result);
        }

        public static string ReturnLastDigit(long number)
        {
            long lastDigit = number % 10L;
            string result = string.Empty;

            switch(Math.Abs(lastDigit))
            {
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
                case 0:
                    result = "zero";
                    break;
            }

            return result;
        }
    }
}
