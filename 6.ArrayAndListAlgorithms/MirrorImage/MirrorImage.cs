using System;
using System.Linq;
using System.Collections.Generic;

namespace MirrorImage
{
    public class MirrorImage
    {
        public static void Main()
        {
            string[] elements = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string position = Console.ReadLine();

            while (position != "Print")
            {
                int index = int.Parse(position);

                for (int i = 0; i < index/2; i++)
                {
                    string temp = elements[i];
                    elements[i] = elements[index - i - 1];
                    elements[index - i - 1] = temp;
                }

                Array.Reverse(elements);

                for (int i = 0; i < (elements.Length-1-index)/2; i++)
                {
                    string temp = elements[i];                                         
                    elements[i] = elements[elements.Length - 2 - index - i];
                    elements[elements.Length - 2 - index -i] = temp;
                }

                Array.Reverse(elements);

                position = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }      
    }
}
