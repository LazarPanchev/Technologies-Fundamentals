using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string numberString = Console.ReadLine();
            Regex regex = new Regex(@"(0x)*[0-9A-F]+\b");

            MatchCollection matches = regex.Matches(numberString);
            foreach (Match  match in matches)
            {
                Console.Write(match+ " ");
            }

            Console.WriteLine();

        }
    }
}
