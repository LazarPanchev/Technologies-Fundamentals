using System;
using System.Linq;

namespace LettersChangeNUmbers
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (var word in input)
            {
                double tempSum = 0;
                var firstLetter = word.First();
                var lastLetter = word.Last();
                double number = double.Parse(word.Substring(1, word.Length - 2));

                if(Char.IsLower(firstLetter))
                {
                    tempSum = number * (firstLetter - 96);
                }

                else
                {
                    tempSum = number / (firstLetter - 64);
                }

                if(char.IsLower(lastLetter))
                {
                    tempSum+=(lastLetter-96);
                }
                else
                {
                    tempSum -= (lastLetter - 64);
                }

                sum += tempSum;

                
            }

            Console.WriteLine("{0:F2}", sum);
        }
    }
}
