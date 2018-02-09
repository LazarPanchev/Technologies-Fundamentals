using System;
using System.Linq;
using System.Collections.Generic;

namespace Dict_Ref
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] input =command.Split(new char[] { ' ','=' }, StringSplitOptions.RemoveEmptyEntries);
                string key = input[0];
                int value=0; 
                bool isInt= int.TryParse(input[1], out value);
                if(isInt)
                {
                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, value);
                    }

                    else
                    {
                        dictionary[key] = value;
                    }
                }

                else
                {
                    if(dictionary.ContainsKey(input[1]))
                    {
                        dictionary[key] = dictionary[input[1]];
                    }

                }

                command = Console.ReadLine();
            }

            foreach (KeyValuePair<string,int> pair in dictionary)
            {
                Console.WriteLine("{0} === {1}",pair.Key, pair.Value);
            }          
        }
    }
}
