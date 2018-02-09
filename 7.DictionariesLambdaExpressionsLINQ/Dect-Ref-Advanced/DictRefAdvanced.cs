using System;
using System.Linq;
using System.Collections.Generic;

namespace Dect_Ref_Advanced
{
    public class DictRefAdvanced
    {
        public static void Main()
        {
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] input = command.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string key = input[0];
                string value = input[1];
                if(IsString(value))
                {
                    string secondKey = input[1];
                    if(dictionary.ContainsKey(secondKey))
                    {
                        dictionary[key] = dictionary[secondKey];
                    }
                }

                else
                {
                    List<int> listIntegers = value
                        .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
                    if(! dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new List<int>();
                    }

                    dictionary[key].AddRange(listIntegers);
                }

                command = Console.ReadLine();
            }

            PrintResult(dictionary);
        }

        private static void PrintResult(Dictionary<string, List<int>> dictionary)
        {
            foreach (KeyValuePair<string,List<int>> pair in dictionary)
            {
                Console.WriteLine("{0} === {1}",pair.Key,string.Join(", ",pair.Value));
            }
        }

        private static bool IsString(string value)
        {
            foreach (char symbol in value)
            {
                if(char.IsDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
