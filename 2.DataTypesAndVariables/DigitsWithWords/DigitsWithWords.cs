
namespace DigitsWithWords
{
    using System;
    public class DigitsWithWords
    {
        public static void Main()
        {
            string numberLikeWord = Console.ReadLine();
            int numberAsNumber = 0;
            switch(numberLikeWord)
            {
                case "zero":
                    numberAsNumber = 0;
                    break;
                case "one":
                    numberAsNumber = 1;
                    break;
                case "two":
                    numberAsNumber = 2;
                    break;
                case "three":
                    numberAsNumber = 3;
                    break;
                case "four":
                    numberAsNumber = 4;
                    break;
                case "five":
                    numberAsNumber = 5;
                    break;
                case "six":
                    numberAsNumber = 6;
                    break;
                case "seven":
                    numberAsNumber = 7;
                    break;
                case "eight":
                    numberAsNumber = 8;
                    break;
                case "nine":
                    numberAsNumber = 9;
                    break;
            }
            Console.WriteLine(numberAsNumber);
        }
    }
}
