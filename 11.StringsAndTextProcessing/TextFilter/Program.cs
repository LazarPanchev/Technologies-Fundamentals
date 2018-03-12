using System;
using System.Text;
using System.IO;

namespace TextFilter
{
    public class Program
    {
        public static void Main()
        {
            string[] bannedWord = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            //File.ReadAllText("bannedWords.txt").Split(new char[] { ' ',','},StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
                //File.ReadAllText("New folder/textInput.txt");

            foreach (var word in bannedWord)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);

        }
    }
}
