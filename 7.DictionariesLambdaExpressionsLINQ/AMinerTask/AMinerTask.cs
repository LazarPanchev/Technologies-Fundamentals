using System;
using System.Linq;
using System.Collections.Generic;

namespace AMinerTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                string resourse = input;
                if (!dictionary.ContainsKey(resourse))
                {
                    dictionary[resourse] = 0;
                }

                int quantity = int.Parse(Console.ReadLine());
                dictionary[resourse] += quantity;

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string,int> pair in dictionary)
            {

                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
