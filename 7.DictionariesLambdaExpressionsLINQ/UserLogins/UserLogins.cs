using System;
using System.Linq;
using System.Collections.Generic;

namespace UserLogins
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            int countUnsuccessfulAtyempts = 0;
            string input = Console.ReadLine();
            while (input != "login")
            {
                string[] commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = commands[0];
                string password = commands[2];
                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, password);
                    
                }

                else
                {
                    dictionary[name] = password;
                }

                input = Console.ReadLine();
            }

            while (input != "end")
            {
                if (input != "login")
                {
                    string[] commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string name = commands[0];
                    string password = commands[2];

                    if (dictionary.ContainsKey(name) && dictionary[name] == password)
                    {
                        Console.WriteLine("{0}: logged in successfully", name);
                    }

                    else
                    {
                        Console.WriteLine("{0}: login failed", name);
                        countUnsuccessfulAtyempts++;
                    }
                }

                input = Console.ReadLine();
            }


            Console.WriteLine($"unsuccessful login attempts: {countUnsuccessfulAtyempts}");
        }
    }
}
