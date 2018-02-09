using System;
using System.Linq;
using System.Collections.Generic;

namespace KeyKeyValueValue
{
    public class KeyKeyValueValue
    {
        public static void Main()
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            string searchingKey = Console.ReadLine();
            string searchingValue = Console.ReadLine();
            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                string[] inputText = Console.ReadLine()
                    .Split(new string[] {" => "},StringSplitOptions.RemoveEmptyEntries);
                string currentkey=inputText[0];
                string[] currentValues = inputText[1].Split(';');
                if(! dictionary.ContainsKey(currentkey))
                {
                    dictionary[currentkey] = new List<string>();
                }

                foreach (string word in currentValues)
                {
                    dictionary[currentkey].Add(word);
                }
            }

            foreach (KeyValuePair<string,List<string>> pair in dictionary)
            {
                string dictKey = pair.Key;
                List<string> dictList = pair.Value;
                if(dictKey.Contains(searchingKey))
                {
                    Console.WriteLine("{0}:", dictKey);
                    foreach (string item in dictList)
                    {
                        if(item.Contains(searchingValue))
                        {
                            Console.WriteLine("-{0}",item);
                        }
                    }
                }

            }
        }
    }
}
