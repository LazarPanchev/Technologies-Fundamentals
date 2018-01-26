namespace SortArrayUsingBubbleSort
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            List<int> inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            bool swaped = false;
            do
            {
                swaped = false;
                for (int i = 0; i < inputArray.Count - 1; i++)
                {
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        swaped = true;
                        int temp = inputArray[i];
                        inputArray[i] = inputArray[i + 1];
                        inputArray[i + 1] = temp;
                    }
                }
            } while (swaped);

            Console.WriteLine(string.Join(" ",inputArray));
        }
    }
}
