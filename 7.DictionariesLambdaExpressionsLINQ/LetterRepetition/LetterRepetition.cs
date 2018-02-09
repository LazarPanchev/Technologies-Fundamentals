using System;
using System.Linq;
using System.Collections.Generic;


namespace LetterRepetition
{
    public class LetterRepetition
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char symbol in input)
            {
                if (dictionary.ContainsKey(symbol))
                {
                    dictionary[symbol]++;
                }

                else
                {
                    dictionary[symbol] = 1;
                }
            }

            foreach (KeyValuePair<char, int> kvp in dictionary)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
