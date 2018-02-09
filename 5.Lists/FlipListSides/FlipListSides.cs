namespace FlipListSides
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class FlipListSides
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool evenList = false;
            if (numbers.Count % 2 == 0)
            {
                evenList = true;
            }

            for (int i = 0; i <numbers.Count/2; i++)
            {
                if (!evenList) 
                {
                    if (i != 0 && i != numbers.Count / 2)   
                    {
                        int temporaryDigit = numbers[i];
                        numbers[i] = numbers[numbers.Count - 1 - i] ;
                        numbers[numbers.Count - 1 - i] = temporaryDigit;
                    }

                    else
                    {
                        continue;
                    }

                }

                else
                {
                    if(i!=0)
                    {
                        int temporaryDigit = numbers[i];
                        numbers[i] = numbers[numbers.Count - 1 - i];
                        numbers[numbers.Count - 1 - i] = temporaryDigit;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
