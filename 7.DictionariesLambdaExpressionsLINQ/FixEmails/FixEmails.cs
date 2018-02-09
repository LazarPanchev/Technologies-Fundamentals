using System;
using System.Linq;
using System.Collections.Generic;

namespace FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                string name = input;
                string email = Console.ReadLine();
                string ending = email.Substring(email.Length - 2, 2).ToLower();
                if (ending !="uk" && ending !="us")
                {
                    dictionary.Add(name, email);

                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
