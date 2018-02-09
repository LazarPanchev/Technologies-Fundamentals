using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();
            foreach(double num in numbers)
            {
                if(dictionary.ContainsKey(num))
                {
                    dictionary[num]++;
                }

                else
                {
                    dictionary[num] = 1;
                }
            }

            foreach(KeyValuePair<double,int> kvp in dictionary)
            {
                Console.WriteLine(kvp.Key+" -> "+kvp.Value);
            }
        }
    }
}
