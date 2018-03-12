using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace ExtractEmails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([\w-.]+\@[\w]+)(\.[\w]+)+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString());
            }
        }
    }
}
