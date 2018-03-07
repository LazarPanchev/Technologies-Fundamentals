using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace NetherRealms
{

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dictHealth = new SortedDictionary<string, int>();
            SortedDictionary<string, double> dictDamage = new SortedDictionary<string, double>();
            string[] inputTokens = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            foreach (var demon in inputTokens)
            {
                string healthCharsPattern = @"(?<chars>[^0-9+\-*\/\.]+?)";
                MatchCollection charsMatches = Regex.Matches(demon, healthCharsPattern);
                int healthSum = 0;
                foreach (Match symbol in charsMatches)
                {
                    char currentChar = char.Parse(symbol.Groups["chars"].Value);
                    healthSum += currentChar;
                }

                dictHealth[demon]=healthSum;
                double damageSum = 0;
                string damagePattern = @"(-?\d+(?:\.\d+)*)";
                MatchCollection damageMatches = Regex.Matches(demon, damagePattern);
                foreach (Match digit in damageMatches)
                {
                    double currentDigit = double.Parse(digit.Groups[1].Value);
                    damageSum += currentDigit;
                }

                foreach (char symbol in demon)
                {
                    if(symbol=='*')
                    {
                        damageSum *= 2;
                        
                    }
                    else if(symbol=='/')
                    {
                        damageSum /= 2;
                    }
                }

                dictDamage[demon] = damageSum;

            }

            foreach (var pair in dictHealth)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} health, {dictDamage[pair.Key]:F2} damage");
            }
        }
    }
}
