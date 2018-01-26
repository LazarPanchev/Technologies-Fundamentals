namespace LargestNElements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LargestNElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int num = int.Parse(Console.ReadLine());
            bool swaped ;
            do
            {
                swaped = false;

                for (int i = 0; i < array.Length-1; i++)
                {
                    if(array[i] < array[i+1])
                    {
                        swaped = true;
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }

            } while (swaped);

            for (int i = 0; i < num; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
     
        }
    }
}
