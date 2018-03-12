using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace CensorShip
{
    class Censorship
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string result = Regex.Replace(text, word, new string('*', word.Length));
            Console.WriteLine(result);
        }
    }
}
