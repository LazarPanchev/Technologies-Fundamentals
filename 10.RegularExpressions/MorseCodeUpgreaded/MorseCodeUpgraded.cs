using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MorseCodeUpgreaded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine()
                .Split(new char[] {'|'},StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            foreach (var token in inputTokens)
            {
                string patternZeroes = @"0";
                string patternOnes = @"1";
                string patternSequenceZeroes = @"0{2,}";
                string patternSequenceOnes = @"1{2,}";
                int totalSum = 0;

                MatchCollection matchesZeroes = Regex.Matches(token, patternZeroes);
                int countOfZeroes = matchesZeroes.Count;
                totalSum += countOfZeroes * 3;
                MatchCollection matchesOnes = Regex.Matches(token, patternOnes);
                int countOfOnes = matchesOnes.Count;
                totalSum += countOfOnes * 5;
                MatchCollection matchesSequenceZeroes = Regex.Matches(token, patternSequenceZeroes);
                
                foreach (Match match in matchesSequenceZeroes)
                {
                    int countOfSequenceZeroes = match.Length;
                    totalSum += countOfSequenceZeroes;
                }

                MatchCollection matchesSequenceOnes = Regex.Matches(token, patternSequenceOnes);

                foreach (Match match in matchesSequenceOnes)
                {
                    int countOfSequenceOnes = match.Length;
                    totalSum += countOfSequenceOnes;
                }

                sb.Append((char)totalSum);
                
            }


            Console.WriteLine(sb.ToString());
        }

        
    }
}
