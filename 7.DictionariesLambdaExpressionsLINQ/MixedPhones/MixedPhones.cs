using System;
using System.Linq;
using System.Collections.Generic;

namespace MixedPhones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, long> dictionary = new SortedDictionary<string, long>();
            string command = Console.ReadLine();

            while (command!= "Over")
            {
                string[] input = command.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                string inputKey = input[0];
                string inputValue = input[1];
                long phoneNumber = 0;
                bool isNumber = long.TryParse(input[1], out phoneNumber);
                if (!isNumber)
                {
                    inputKey = input[1];
                    phoneNumber = int.Parse(input[0]);
                }

                dictionary.Add(inputKey, phoneNumber);
                command = Console.ReadLine();
            }

            foreach (KeyValuePair<string,long> pair in dictionary)
            {
                Console.WriteLine("{0} -> {1}",pair.Key, pair.Value);
            }
        }
    }
}
