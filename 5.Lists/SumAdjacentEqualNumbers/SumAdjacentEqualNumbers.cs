namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();
            decimal sum = 0.0M;
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i + 1]) 
                {
                    sum = numbers[i] + numbers[i + 1];
                    numbers[i] = sum;
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
