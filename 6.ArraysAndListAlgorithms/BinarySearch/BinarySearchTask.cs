using System;
using System.Linq;
using System.Collections.Generic;

namespace BinarySearch
{
    public class BinarySearchTask
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numberToFind = int.Parse(Console.ReadLine());

            int countLinearSearch = LinearSearch(numbers, numberToFind);
            int binarySearchCount = BinarySearch(numbers, numberToFind);
            numbers.Sort();
            if (numbers.BinarySearch(numberToFind)>=0)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine($"Linear search made {countLinearSearch} iterations");
            Console.WriteLine($"Binary search made {binarySearchCount} iterations");

        }

        private static int BinarySearch(List<int> numbers, int numberToFind)
        {
            numbers.Sort();

            int min = 0;
            int max = numbers.Count-1;
            int count = 0;
            while (min <= max)
            {
                int midPoint = (min + max) / 2;
                count++;
                if (numbers[midPoint] < numberToFind)
                {
                    min = midPoint + 1;
                }

                if (numbers[midPoint] > numberToFind)
                {
                    max = midPoint - 1;
                }

                if (numbers[midPoint] == numberToFind)
                {
                    break;
                }
                
            }

            return count;
        }

        private static int LinearSearch(List<int> numbers, int numberToFind)
        {
            int count = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                count++;
                if (numbers[i] == numberToFind)
                {
                    return count;
                }

            }
            return count;
        }
    }
}
