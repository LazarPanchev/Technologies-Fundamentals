using System;
using System.Linq;
using System.Collections.Generic;

namespace MirrorImage
{
    public class MirrorImage
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                //.Select(int.Parse)
                .ToArray();
           
            string command = Console.ReadLine();

            while(command !="Print")
            {
                int indexNum = int.Parse(command);
                
                for (int i = 0; i <(indexNum-1)/2; i++)
                {
                    string temp = input[i];
                    input[i] = input[indexNum - 1 - i];
                    input[indexNum - 1 - i] = temp;
                }

                int currentIndex= 0;
                int middleIndex = indexNum + ((input.Length-1 - indexNum + 1) / 2);
                for (int i = indexNum+1; i < middleIndex; i++)
                {
                    string temp = input[i];
                    input[i] = input[input.Length-1 - currentIndex];
                    input[input.Length-1 - currentIndex] = temp;
                    currentIndex++;
                }
              
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
