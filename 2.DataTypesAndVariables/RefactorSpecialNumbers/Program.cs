
namespace RefactorSpecialNumbers
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int numbersForCheck = int.Parse(Console.ReadLine());
            
            for (int num = 1; num <= numbersForCheck; num++)
            {
                int currenNumber=num;
                int sum = 0;
                while (currenNumber > 0)
                {
                    int lastDigit = currenNumber % 10;
                    currenNumber= currenNumber/ 10;
                    sum += lastDigit;
                }
                bool isNumberEqual = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{num} -> {isNumberEqual}");
            }

        }
    }
}
