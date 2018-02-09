namespace LongestIncreasingSubsequence
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
<<<<<<< HEAD
            List<int> input =Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int n = input.Count;
            int[] len = new int[n];
            int[] prev = new int[1];

            int left = 0;
            for (int i = 1; i < n; i++)
            {
                len[i] = 1 + len[left];
                prev[i] = left;
            }





=======
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] len = new int[numbers.Count];
            int[] prev = new int[numbers.Count];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j <= i; j++)
                {
                    if (numbers[j] < numbers[i] && len[j] + 1 > len[i])  // len + nego > ot nai-golqmata do momenta
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }

                    if (len[i] > maxLength)
                    {
                        maxLength = len[i];
                        lastIndex = i;
                    }
                }
            }

            List<int> longesSubSeq = new List<int>();
            while (lastIndex != -1)
            {
                longesSubSeq.Add(numbers[lastIndex]);

                lastIndex = prev[lastIndex];
            }

            longesSubSeq.Reverse();

            Console.WriteLine(string.Join(" ", longesSubSeq));
>>>>>>> 84d03160caa7d23570767b816c70d87d2f40459c
        }
    }
}
