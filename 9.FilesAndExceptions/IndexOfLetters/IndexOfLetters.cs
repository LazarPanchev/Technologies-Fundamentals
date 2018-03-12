using System;
using System.IO;
using System.Linq;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {

            //string word = Console.ReadLine();
            File.Delete("output.txt");
            File.Delete("input.txt");
            File.AppendAllText("input.txt", "abcz");
            string word = File.ReadAllText("input.txt");
            for (int i = 0; i < word.Length; i++)
            {
                char current = word[i];
                int result = word[i] - 97;
                //Console.WriteLine("{0} -> {1}", current, result);
                var currentResult= string.Format("{0} -> {1}"+Environment.NewLine, current, result);
                File.AppendAllText("output.txt",currentResult);
            }
        }
    }
}
