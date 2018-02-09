using System;
using System.Linq;
using System.Collections.Generic;

namespace ForumTopics
{
    public class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            while (command != "filter")
            {
                string[] inputTokens = command.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string topic = inputTokens[0];
                List<string> tags = inputTokens[1]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (!dictionary.ContainsKey(topic))
                {
                    dictionary[topic] = new List<string>();  //dictionary.Add(topic,new List<string>());
                }

                foreach (string tag in tags)
                {
                    if (!dictionary[topic].Contains(tag))
                    {
                        dictionary[topic].Add(tag);
                    }
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            List<string> searchedTags = command
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (KeyValuePair<string, List<string>> pair in dictionary)
            {
                bool printTpics = true;
                string topic = pair.Key;
                List<string> tags = pair.Value;
                foreach (string searchTag in searchedTags)
                {
                    if (!dictionary[topic].Contains(searchTag))
                    {                  
                        printTpics = false;
                        break;
                    }
                }

                if (printTpics)
                {
                    Console.WriteLine("{0} | #{1}", topic, string.Join(", #", tags));
                }
            }
        }
    }
}
