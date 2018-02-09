namespace SumReversedNumber
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int temporaryNum = 0;
                int currentNumber = input[i];
                while (currentNumber > 0)
                {

                    int lastDigit = currentNumber % 10;
                    temporaryNum = temporaryNum * 10 + lastDigit;
                    currentNumber = currentNumber / 10;
                }

                sum += temporaryNum;
            }

            Console.WriteLine(sum);
        }
    }
}