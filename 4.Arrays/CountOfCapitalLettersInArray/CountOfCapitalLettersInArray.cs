namespace CountOfCapitalLettersInArray
{
    using System;
    using System.Linq;

    public class CountOfCapitalLettersInArray
    {
        public static void Main()
        {
            string[] inputArray = Console.ReadLine().Split(' ').ToArray();
            int countOfCapitalLetters = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                string currentWord = inputArray[i];

                if(currentWord.Length==1)
                {
                    char currentChar = char.Parse(inputArray[i]);
                    if(char.IsUpper(currentChar))
                    {
                        countOfCapitalLetters++;
                    }
                }
            }

            Console.WriteLine(countOfCapitalLetters);
        }
    }
}
