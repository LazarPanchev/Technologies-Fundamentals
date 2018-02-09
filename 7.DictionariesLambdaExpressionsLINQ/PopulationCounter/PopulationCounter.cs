using System;
using System.Linq;
using System.Collections.Generic;

namespace PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, long> totalPop = new Dictionary<string, long>();
            string input = Console.ReadLine();
            //long totalPopulation = 0L;
            while (input != "report")
            {
                string[] tokens = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string city = tokens[0];
                string country = tokens[1];
                int population = int.Parse(tokens[2]);

                if(! dictionary.ContainsKey(country))
                {
                    dictionary[country]= new Dictionary<string, int>();
                }

                dictionary[country].Add(city, population);

                if(! totalPop.ContainsKey(country))
                {
                    totalPop[country] = population;
                }

                else
                {
                    totalPop[country] += population;
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, long> pair in totalPop.OrderByDescending(x => x.Value))
            {
                string country = pair.Key;
                long totalCityPopulation = pair.Value;

                Console.WriteLine("{0} (total population: {1})", country, totalPop[country]);
                foreach (KeyValuePair<string, int> secondPair in dictionary[country].OrderByDescending(x => x.Value))
                {
                    string city = secondPair.Key;
                    int currentPopulation = secondPair.Value;
                    Console.WriteLine("=>{0}: {1}", city, currentPopulation);
                }
            }
        }
    }
}
