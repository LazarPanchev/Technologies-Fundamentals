namespace SumArrays
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int[] firstArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var len = Math.Max(firstArray.Length, secondArray.Length);
            int[] result = new int[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
