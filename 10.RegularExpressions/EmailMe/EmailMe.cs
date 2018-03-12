using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(.*)@(.*)";
            Match match = Regex.Match(Console.ReadLine(), pattern);
            string wordsBefore = match.Groups[1].Value;
            string wordsAfter = match.Groups[2].Value;
            int sumBefore = SumChars(wordsBefore);
            int sumAfter = SumChars(wordsAfter);
            int result = sumBefore - sumAfter;
            Console.WriteLine(result>=0 ? "Call her!" : "She is not the one.");

        }

        private static int SumChars(string wordsBefore)
        {
            int sum = 0;
            for (int i = 0; i < wordsBefore.Length; i++)
            {
                sum += wordsBefore[i];
            }

            return sum;
        }
    }
}
