namespace LastKNumberSum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class LastKNUmberSum
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();
            int bestStart = 0;
            int bestLen = 1;
            int currentLen = 1;
            int currentStart = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLen++;
                    if (currentLen > bestLen)
                    {
                        bestLen = currentLen;
                        bestStart = currentStart;
                    }
                }

                else
                {
                    currentLen = 1;
                    currentStart = i;
                }
            }

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }

    }
}

