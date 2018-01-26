using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageCharacterDelimiter
{
    public class AverageCharcterDelimiter
    {
        public static void Main()
        {
            string[] inputString = Console.ReadLine().Split(' ').ToArray();
            int sum = 0;
            int lenght = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                sum += CharSumText(inputString[i]);
                lenght += CheckLength(inputString[i]);
            }

            char delimiter = (char)(sum / lenght);
            if(Char.IsLetter(delimiter))
            {
                delimiter=Char.ToUpper(delimiter);
            }

            Console.WriteLine(string.Join("{0}",inputString),delimiter);
        }

       private static int CheckLength(string text)
       {
           int countChars = 0;
           foreach (char symbol in text)
           {
               countChars++;
           }
       
           return countChars;
           
       }

        public static int CharSumText(string text)
        {
            int sum = 0;
            foreach (char symbol in text)
            {
                sum += symbol;
            }

            return sum;
        }
    }
}
