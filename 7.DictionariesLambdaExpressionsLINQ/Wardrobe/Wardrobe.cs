using System;
using System.Linq;
using System.Collections.Generic;

namespace Wardrobe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();
            int nLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < nLines; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string colours = inputTokens[0];
                string[] clothes = inputTokens[1].Split(',');

                if (!dictionary.ContainsKey(colours))
                {
                    dictionary.Add(colours, new Dictionary<string, int>());
                }

                Dictionary<string, int> clothDb = dictionary[colours];
                foreach (string cloth in clothes)
                {                  
                    if (!clothDb.ContainsKey(cloth))
                    {
                        clothDb.Add(cloth, 0);
                    }

                    clothDb[cloth]++;
                }
            }

            string[] searchedTokens = Console.ReadLine().Split(' ');
            string searchingColour = searchedTokens[0];
            string searchingCloth = searchedTokens[1];

            foreach (KeyValuePair<string, Dictionary<string, int>> pair in dictionary)
            {
                string colour = pair.Key;
                Dictionary<string, int> clothesData = pair.Value;

                Console.WriteLine("{0} clothes:", colour);

                foreach (KeyValuePair<string, int> clothData in clothesData)
                {
                    string cloth = clothData.Key;
                    int quantity = clothData.Value;

                    Console.Write("* {0} - {1}", cloth, quantity);
                    if (colour == searchingColour && cloth == searchingCloth)
                    {
                        Console.Write(" (found!) ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}