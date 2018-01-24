namespace IncreasingSequenceOfElements
{
    using System;
    using System.Linq;

    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIncreasing = true;
            for (int i = 0; i <array.Length-1; i++)
            {
                int currentNum = array[i];
                if(!(array[i+1]>currentNum))
                {
                    isIncreasing = false;
                }
            }

            if(isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
