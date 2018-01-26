using System;
using System.Linq;
using System.Collections.Generic;

namespace DecodeRadioFrequences
{
    public class DecodeRadioFrequences
    {
        public static void Main()
        {
            string[] array = Console.ReadLine()
                .Split(' ')
                .ToArray();
            List<char> result = new List<char>();
            for (int i = 0; i < array.Length; i++)
            {
                string[] arrayWord = array[i].Split('.');
                int leftPart = int.Parse(arrayWord[0]);
                int rightPart = int.Parse(arrayWord[1]);

                char leftChar = (char)leftPart;
                char rightChar = (char)rightPart;
                if (leftPart != 0)
                {                   
                    result.Insert(i, leftChar);
                }

                if (rightPart != 0)
                {                   
                    result.Insert(result.Count - 1 - i, rightChar);
                }
            }

            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }

    }
}
