using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPattern = @"((?<text>[^0-9]+)(?<number>\d+))";
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            StringBuilder substring = new StringBuilder();
            MatchCollection matches = Regex.Matches(input, textPattern);
            HashSet<char> charSet = new HashSet<char>();
            foreach (Match match in matches)
            {
                string text = match.Groups["text"].Value;
                int number = int.Parse(match.Groups["number"].Value);

                if (text.Length > 1)
                {
                    for (int i = 0; i < number; i++)
                    {
                        for (int j = 0; j < text.Length; j++)
                        {
                            if(char.IsLower(text[j]))
                            {
                                substring.Append(char.ToUpper(text[j]));
                            }
                            else
                            {
                                substring.Append(text[j]);
                            }
                        }

                        sb.Append(substring);
                        substring.Clear();
                    }

                    foreach (char symbol in text)
                    {
                        charSet.Add(char.ToUpper(symbol));
                    }
                }

                else
                {
                    if (Char.IsLower(char.Parse(text)))
                    {
                        for (int i = 0; i < number; i++)
                        {
                            sb.Append(Char.ToUpper(char.Parse(text)));
                        }

                        charSet.Add(Char.ToUpper(char.Parse(text)));
                    }

                    else
                    {
                        for (int i = 0; i < number; i++)
                        {
                            sb.Append(Char.ToUpper(char.Parse(text)));
                        }

                        charSet.Add(Char.ToUpper(char.Parse(text)));
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {charSet.Count}");
            Console.WriteLine(sb.ToString());
        }
    }
}
