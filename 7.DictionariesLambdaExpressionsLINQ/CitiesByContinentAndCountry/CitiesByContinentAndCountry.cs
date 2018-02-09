using System;
using System.Linq;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    public class CitiesByContinentAndCountry
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dictionary = new Dictionary<string, Dictionary<string, List<string>>>();
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

        private static void PrintCities(Dictionary<string, Dictionary<string, List<string>>> dictionary)
        {
            foreach(KeyValuePair<string,Dictionary<string,List<string>>> pair in dictionary)
            {
                string continent = pair.Key;
                Dictionary<string,List<string>> country = pair.Value;
                Console.WriteLine($"{continent}:");
                foreach (KeyValuePair<string,List<string>> secondPair in country)
                {
                    string countryInContinent = secondPair.Key;
                    List <string> cities= secondPair.Value;
                    Console.WriteLine("  {0} -> {1}", countryInContinent, string.Join(", ",cities));
                    
                }
            }
        }

        private static void AddCities(Dictionary<string, Dictionary<string, List<string>>> dictionary, string continent, string country, string city)
        {
            if(! dictionary.ContainsKey(continent))
            {
                dictionary[continent] = new Dictionary<string, List<string>>();
            }

            if(! dictionary[continent].ContainsKey(country))
            {
                dictionary[continent][country] = new List<string>();
            }

            dictionary[continent][country].Add(city);
        }
    }
}
