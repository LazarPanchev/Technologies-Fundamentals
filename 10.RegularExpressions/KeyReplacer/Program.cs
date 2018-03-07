using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeyReplacer
{
    class Program
    {
        static void Main()
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();

            string pattern = @"^(?<startKey>[A-Za-z]+)[|<\\](?<searchedText>.*)[|<\\](?<endKey>[A-za-z]+)$";
            Match myMatch = Regex.Match(keyString, pattern);
            string leftSide = myMatch.Groups["startKey"].Value;
            string rightSide = myMatch.Groups["endKey"].Value;
            string newPattern = $@"{leftSide}(?<searchedText>.*?){rightSide}";

            StringBuilder sb = new StringBuilder();

            Regex regex = new Regex(newPattern);
            MatchCollection newMatches = regex.Matches(textString);
            foreach (Match match in newMatches)
            {
                string searchedText = match.Groups["searchedText"].Value;
                sb.Append(searchedText);
            }

            if (sb.Length == 0)
            {
                Console.WriteLine("Empty result");
            }

            else
            {
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
