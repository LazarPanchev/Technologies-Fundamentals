namespace SortArrayUsingInsertionSort
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            List<int> inputArray = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            for (int firstUnsorted = 0; firstUnsorted < inputArray.Count-1; firstUnsorted++)
            {
                var i = firstUnsorted + 1;
                while (i>1)
                {

                    if(inputArray[i-1]> inputArray[i])
                    {
                        int temp = inputArray[i];
                        inputArray[i] = inputArray[i - 1];
                        inputArray[i - 1] = temp;
                    }
                }
                
            }

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
