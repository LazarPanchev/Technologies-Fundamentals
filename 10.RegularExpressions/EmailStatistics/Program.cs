using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]{5,})@([a-z]{3,}.[c|o|r|g|m|b]+)($|(?=\s))";
            int nLines = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            for (int i = 0; i < nLines; i++)
            {
                string email = Console.ReadLine();
                Match match = Regex.Match(email, pattern);
                if (match.Success)
                {
                    string username = match.Groups[1].Value;
                    string domain = match.Groups[2].Value;

                    if (!dictionary.ContainsKey(domain))
                    {
                        dictionary.Add(domain, new List<string>());
                    }
                    if (!dictionary[domain].Contains(username))
                    {
                        dictionary[domain].Add(username);
                    }
                }
                
            }

            foreach (var pair in dictionary.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{pair.Key}:");
                List<string> usernamesList = pair.Value;
                foreach (var username in usernamesList)
                {
                    Console.WriteLine($"### {username}");
                }
            }
        }
    }
}
