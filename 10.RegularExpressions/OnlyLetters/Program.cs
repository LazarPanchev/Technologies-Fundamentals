using System;
using System.Text;
using System.Text.RegularExpressions;

namespace OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\d+)";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                string number =match.Groups[1].Value;
                int indexOfpattern = input.IndexOf(number.ToString());
                if (indexOfpattern + match.Length < input.Length)
                {
                    char newString = input[indexOfpattern+match.Length];
                    input = input.Replace(number, newString.ToString());
                }
            }

            Console.WriteLine(input);
        }
    }
}
