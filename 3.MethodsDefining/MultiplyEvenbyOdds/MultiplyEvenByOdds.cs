namespace MultiplyEvenbyOdds
{
    using System;
    public class MultiplyEvenByOdds
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int multiplyEvenOdd = GetMultipleOfEvensAndOdds(inputNumber);
            Console.WriteLine(multiplyEvenOdd);
        }
        public static int GetMultipleOfEvensAndOdds(int number)
        {
            return GetSumOfEvenDigits(Math.Abs(number)) * GetSumOfOddDigits(Math.Abs(number));
        }
        public static int CalculateSum(int number, int reminder)
        {
            int sum = 0;
            foreach (char symbol in number.ToString())
            {
                if (symbol % 2 == reminder && symbol != '-')
                {
                    sum += symbol - '0';
                }
            }
            return sum;
        }
        public static int GetSumOfOddDigits(int number)
        {
            return CalculateSum(number, 1);
        }
        public static int GetSumOfEvenDigits(int number)
        {
            return CalculateSum(number, 0);
        }
    }
}
