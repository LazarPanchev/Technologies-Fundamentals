using System;
using System.Linq;
using System.Collections.Generic;

namespace ExamShoping
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "exam time")
            {
                if (input != "shopping time")
                {
                    string[] command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string action = command[0];
                    string inputKey = command[1];
                    int inputValue = int.Parse(command[2]);

                    if (command[0] == "stock")
                    {
                        if (!dictionary.ContainsKey(inputKey))
                        {
                            dictionary.Add(command[1], inputValue);
                        }

                        else
                        {
                            dictionary[command[1]] += inputValue;
                        }
                    }

                    else if (command[0] == "buy")
                    {
                        if (!dictionary.ContainsKey(inputKey))
                        {
                            Console.WriteLine("{0} doesn't exist", inputKey);
                        }

                        else if(dictionary[inputKey]==0)
                        {
                            Console.WriteLine("{0} out of stock", inputKey);
                        }

                        else if(dictionary[inputKey]<inputValue)
                        {
                            dictionary[inputKey] = 0;
                        }

                        else
                        {
                            dictionary[inputKey] -= inputValue;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach(KeyValuePair<string,int> pair in dictionary)
            {
                if(pair.Value != 0)
                {
                    Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                }
            }
        }
    }
}
