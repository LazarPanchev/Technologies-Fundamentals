namespace CountOfOddNumbersInArray
{
    using System;
    using System.Linq;

    public class CountOfOddNumbersInArray
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 0; i <array.Length; i++)
            {
                if(array[i]%2!=0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
