using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace ExtarctSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string pattern = $@"\b{word}\b";
            string[] sentances = Console.ReadLine()
                .Split(new char[] { '.', '!', '?' },StringSplitOptions.RemoveEmptyEntries);

            Regex match = new Regex(pattern);
            foreach (var sentance in sentances)
            {
                 if(match.IsMatch(sentance))
                {
                    Console.WriteLine(sentance);
                }
            }

        }
    }
}
