using System;
using System.Linq;
using System.Text;

namespace UnicodeCharacters
{
    public class Program
    {
        public static void Main()

        {

            string input = Console.ReadLine();
            var chars = input
                .Select(c => (int)c)
                .Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);
            Console.WriteLine(result);
        }
    }
}
