namespace TripleSum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class TripleSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool IsContainsSum = false;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    if(numbers.Contains(sum))
                    {
                        IsContainsSum = true;
                        Console.WriteLine("{0} + {1} == {2}", numbers[i], numbers[j], sum);
                    }
                }
            }

            if(!IsContainsSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
