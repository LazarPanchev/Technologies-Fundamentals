using System;
using System.Linq;
using System.Collections.Generic;

namespace PhoneBook
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();

            while (input != "END")
            {
                string[] commands = input.Split(' ');
                string action = commands[0];
                string name;
                string number;
                switch (action)
                {
                    case "ListAll":
                        foreach(KeyValuePair<string, string> pair in dictionary)
                        {
                            name = pair.Key;
                            number = pair.Value;
                            Console.WriteLine($"{name} -> {number}", name, number);
                        }

                        break;
                    case "A":
                        name = commands[1];
                        number = commands[2];
                        dictionary[name] = number;
                        break;

                    case "S":
                        name = commands[1];
                        
                        if(dictionary.ContainsKey(name))
                        {
                            number = dictionary[name];
                            Console.WriteLine($"{name} -> {number}", name, number);
                        }

                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }

                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
