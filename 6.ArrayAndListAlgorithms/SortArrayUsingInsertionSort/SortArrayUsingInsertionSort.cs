namespace SortArrayUsingInsertionSort
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count-1; i++)
            {
                int currentIndex = i + 1;
                while(currentIndex>0)
                {
                    if(numbers[currentIndex]<numbers[currentIndex-1])
                    {
                        var temp = numbers[currentIndex];
                        numbers[currentIndex] = numbers[currentIndex-1];
                        numbers[currentIndex-1] = temp;
                    }

                    currentIndex--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
