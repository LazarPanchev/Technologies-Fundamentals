using System;
using System.IO;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = Console.ReadLine()
            //    .Split(' ')
            //    .Select(int.Parse)
            //    .ToArray();
            File.Delete("output.txt");
            var lines = File.ReadAllLines("input.txt");
            foreach (var line in lines)
            {
                int[] numbers = line.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int middleindex = 0;
                bool findMiddleDigit = false;
                for (int i = 0; i < numbers.Length; i++)
                {

                    int currentIndex = i;
                    int leftSum = SumLeftPart(numbers, currentIndex);
                    int rightSum = SumRightPart(numbers, currentIndex);
                    if (leftSum == rightSum)
                    {
                        middleindex = currentIndex;
                        findMiddleDigit = true;
                    }
                }

                if (findMiddleDigit)
                {
                    //Console.WriteLine(middleindex);
                    File.AppendAllText("output.txt", middleindex.ToString()+Environment.NewLine);
                }

                else
                {
                    //Console.WriteLine("no");
                    File.AppendAllText("output.txt", "no"+Environment.NewLine);
                }
            }

        }

        public static int SumLeftPart(int[] numbers, int currentIndex)
        {
            int sum = 0;
            for (int i = 0; i < currentIndex; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static int SumRightPart(int[] numbers, int currentIndex)
        {
            int sum = 0;
            for (int i = currentIndex + 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
    }

