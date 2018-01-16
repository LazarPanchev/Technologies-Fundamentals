namespace CountOccurrencesOfLargerNumbersInArray
{
    using System;
    using System.Linq;

    public class CountOccurrencesOfLargerNumberInArray
    {
        public static void Main()
        {
            double[] arrayOfNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double numberForCheck = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arrayOfNums.Length; i++)
            {
                if(arrayOfNums[i]>numberForCheck)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

        }
    }
}
