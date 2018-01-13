namespace OddNumbersAtOddPositions
{
    using System;
    using System.Linq;

    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if(i%2!=0 && array[i]%2!=0)
                {
                    Console.WriteLine($"Index {i} -> {array[i]}");
                }
            }
        }
    }
}
