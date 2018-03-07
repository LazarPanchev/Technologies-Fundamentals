using System;
using System.Text.RegularExpressions;
using System.Linq;


namespace MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string regex = @"\+\d{3}([\s|\-])\d{1}\1\d{3}\1\d{4}";
            string text = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(text, regex);
            var phoneMatches = matchedNames.Cast<Match>().Select(a => a.Value.Trim().ToArray());
            Console.WriteLine(string.Join(", ", phoneMatches));
        }
    }
}
