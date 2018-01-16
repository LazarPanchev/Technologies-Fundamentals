namespace ArrayElementsEquelToTheirIndex
{
    using System;
    using System.Linq;

    public class ArrayElementsEquelToTheirIndex
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentIndex = i;
                if(numbers[i]==currentIndex)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
