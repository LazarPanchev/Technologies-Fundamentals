using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .ToLower()
                .Split(new char[] {' '} ,StringSplitOptions.RemoveEmptyEntries )
                .ToList();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in input)
            {
                if(dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }

                else
                {
                    dictionary[word] = 1;
                }
            }
            input.Clear();

            foreach (KeyValuePair<string,int> item in dictionary)
            {
                int value = item.Value;
                if(value %2 != 0)
                {
                    input.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", input));
                

        }
    }
}
