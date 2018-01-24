namespace LargestCommonEnd
{
    using System;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] secondArray = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int startCommonWords = FindMaxCount(firstArray, secondArray);
            Array.Reverse(firstArray);
            secondArray = secondArray.Reverse().ToArray();
            int endCommonWords = FindMaxCount(firstArray, secondArray);

            Console.WriteLine($"{Math.Max(startCommonWords, endCommonWords)}");
        }

        public static int FindMaxCount(string[] firstArr, string[] secondArr)
        {
            int lenght = Math.Min(firstArr.Length, secondArr.Length);
            int counter = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (firstArr[i].Equals(secondArr[i]))
                {
                    counter++;
                }

                else
                {
                    break;
                }
            }

            return counter;
        }
    }
}
