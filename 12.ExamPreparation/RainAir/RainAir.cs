using System;
using System.Linq;
using System.Collections.Generic;
namespace RainAir
{
    class RainAir
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
            while (input != "I believe I can fly!")
            {
                if (input.Contains("="))
                {
                    string[] tokens = input.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                    string customerName = tokens[0];
                    string secondName = tokens[1];
                    dictionary[customerName].Clear();
                    foreach (var flight in dictionary[secondName])
                    {
                        dictionary[customerName].Add(flight);
                    }
                }
                else
                {
                    string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string customerName = tokens[0];
                    int[] flightsNumbers = tokens.Skip(1).Select(int.Parse).ToArray();

                    if (!dictionary.ContainsKey(customerName))
                    {
                        dictionary[customerName] = new List<int>();
                    }

                    dictionary[customerName].AddRange(flightsNumbers);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in dictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#{pair.Key} ::: {string.Join(", ", pair.Value.OrderBy(x => x))}");
            }
        }
    }
}
