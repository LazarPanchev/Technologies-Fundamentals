using System;
using System.Linq;
using System.Collections.Generic;

namespace DictrefAdvanced
{
    public class Program
    {
        public static void Main()
        {
            var data = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputTokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                if (IsName(inputTokens[1]))
                {
                    string otherName = inputTokens[1];
                    if(data.ContainsKey(otherName))
                    {
                        List<int> otherNumbers = data[otherName]; 

                        if(!data.ContainsKey(name))  //if does't exist -> create it!
                        {
                            data.Add(name, new List<int>());
                        }

                        data[name].Clear();
                        data[name].AddRange(otherNumbers);   // false: data[name]= otherNumbers
                    }                 
                }

                else
                {
                    int[] numbers = inputTokens[1]
                        .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<int>());
                    }

                    data[name].AddRange(numbers);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<int>> record in data)
            {
                string name = record.Key;
                List<int> numbers = record.Value; //the list-> numbers
                Console.WriteLine("{0} === {1}", name, string.Join(", ", numbers));
            }
        }

        public static bool IsName(string input)
        {
            foreach (char symbol in input)
            {
                if (char.IsLetter(symbol))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
