namespace ReverseAnArrayOfStrings
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ReverseAnArrayOfStrings
    {
        public static void Main()
        {
            string[] inputText = Console.ReadLine().Split(' ');
            string[] reversedArray = new string[inputText.Length];
            int reversedIndex = 0;
            for (int i = inputText.Length-1; i >=0; i--)
            {
                reversedArray[reversedIndex] = inputText[i];
                reversedIndex++;
            }

            Console.WriteLine(string.Join(" ",reversedArray)); ;
                
        }
    }
}
