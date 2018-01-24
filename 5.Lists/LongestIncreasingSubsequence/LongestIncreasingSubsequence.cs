namespace LongestIncreasingSubsequence
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
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





        }
    }
}
