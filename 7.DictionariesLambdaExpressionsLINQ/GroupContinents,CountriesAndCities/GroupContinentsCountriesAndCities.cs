using System;
using System.Linq;
using System.Collections.Generic;

namespace GroupContinents_CountriesAndCities
{
    public class GroupContinentsCountriesAndCities
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> dictionary =
                new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                AddCities(dictionary, continent, country, city);
            }

            PrintCities(dictionary);
        }

        private static void PrintCities(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> dictionary)
        {
            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> pair in dictionary)
            {
                string continent = pair.Key;
                SortedDictionary<string, SortedSet<string>> country = pair.Value;
                Console.WriteLine($"{continent}:");
                foreach (KeyValuePair<string, SortedSet<string>> secondPair in country)
                {
                    string countryInContinent = secondPair.Key;
                    SortedSet<string> cities = secondPair.Value;
                    Console.WriteLine("  {0} -> {1}", countryInContinent, string.Join(", ", cities));

                }
            }
        }

        private static void AddCities(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> dictionary, string continent, string country, string city)
        {
            if (!dictionary.ContainsKey(continent))
            {
                dictionary[continent] = new SortedDictionary<string, SortedSet<string>>();
            }

            if (!dictionary[continent].ContainsKey(country))
            {
                dictionary[continent][country] = new SortedSet<string>();
            }

            dictionary[continent][country].Add(city);
        }
    }
}

