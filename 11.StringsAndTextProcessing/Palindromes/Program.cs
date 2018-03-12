using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] delimiter = { ' ', ',', '.', '?', '!' };
            string[] text = Console.ReadLine().Split(delimiter,StringSplitOptions.RemoveEmptyEntries);
            //StringBuilder sb = new StringBuilder();
            List<string> result = new List<string>();
            foreach (var word in text.OrderBy(x=>x))
            {
                if(IsPollindrome(word))
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ",result));
        }

        private static bool IsPollindrome(string word)
        {
            for (int i = 0; i <=word.Length/2; i++)
            {
                if(word[i]==word[word.Length-1-i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
