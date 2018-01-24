namespace SplitbyWordCasting
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SplitByWordCasting
    {
        static List<string> lowerCase = new List<string>();
        static List<string> upperCase = new List<string>();
        static List<string> mixedCase = new List<string>();


        public static void Main()
        {
            char[] separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '\'', '"', '\\', '/', '[', ']', ' ' };
            List<string> inputText = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < inputText.Count; i++)
            {
                CheckCaseForWord(inputText[i]);
            }

            PrintLists();

        }

        private static void PrintLists()
        {
            Console.Write("Lower-case: ");
            Console.WriteLine(String.Join(", ", lowerCase));
            Console.Write("Mixed-case: ");
            Console.WriteLine(String.Join(", ", mixedCase));
            Console.Write("Upper-case: ");
            Console.WriteLine(String.Join(", ", upperCase));

        }

        private static void CheckCaseForWord(string word)
        {
            int isLower = 0;
            int isUpper = 0;
            foreach (char symbol in word)
            {
                if (char.IsLower(symbol))
                {
                    isLower++;
                }

                if (char.IsUpper(symbol))
                {
                    isUpper++;
                }

            }

            if (isLower == word.Length)
            {
                lowerCase.Add(word);
            }

            else if (isUpper == word.Length)
            {
                upperCase.Add(word);

            }

            else
            {
                mixedCase.Add(word);
            }


        }
    }
}