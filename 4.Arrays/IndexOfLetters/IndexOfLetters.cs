namespace IndexOfLetters
{
    using System;
    using System.Linq;

    public class IndexOfLetters
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char current = word[i];
                int result = word[i] - 97;
                Console.WriteLine("{0} -> {1}", current, result);
            }
        }
    }
}
