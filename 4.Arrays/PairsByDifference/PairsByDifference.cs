namespace PairsByDifference
{ 
    using System;
    using System.Linq;

    public class PairsByDifference
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                for (int j = i; j < numbers.Length; j++)
                {
                    int currentDifference = Math.Abs(currentNum - numbers[j]);
                    if (currentDifference==difference)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
