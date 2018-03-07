using System;
using System.Text;

namespace CountSubstingOccurences
{
    public class CountSubstringOccurences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            var count = 0;
            var index = text.IndexOf(pattern);
            while (index !=-1)
            {
                count++;
                index = text.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
