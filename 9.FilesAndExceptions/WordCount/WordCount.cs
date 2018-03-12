using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var wordCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                wordCount[word] = 0;
            }
            foreach (string word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            foreach (var line in wordCount.OrderByDescending(x => x.Value))
            {

                File.AppendAllText("results.txt", line.Key + " -> " + line.Value + Environment.NewLine);
            }


        }
    }
}
