namespace SmallestElementInArray
{
    using System;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int smallestElement = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]<smallestElement)
                {
                    smallestElement = numbers[i];
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
