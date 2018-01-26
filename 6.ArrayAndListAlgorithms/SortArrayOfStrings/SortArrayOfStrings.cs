using System;
using System.Linq;
using System.Collections.Generic;

namespace SortArrayOfStrings
{
    public class SortArrayOfStrings
    {
        public static void Main()
        {
            string[] inputString = Console.ReadLine()
                .Split(' ');

            for (int i = 0; i < inputString.Length-1; i++)
            {
                int currentIndex = i + 1;
                while(currentIndex>0)
                {
                    if (inputString[currentIndex].CompareTo(inputString[currentIndex-1]) < 0)
                    {
                        var temp = inputString[currentIndex];
                        inputString[currentIndex] = inputString[currentIndex-1];
                        inputString[currentIndex-1] = temp;                     
                    }

                    currentIndex--;
                }                
            }

            Console.WriteLine(string.Join(" ", inputString));
        }
    }
}
