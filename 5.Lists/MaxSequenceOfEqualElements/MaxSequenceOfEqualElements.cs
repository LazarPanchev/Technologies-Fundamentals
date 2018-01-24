namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int maxCount = 0;
            int longestNumSec = 0;
            for (int i = 0; i < inputList.Count - 1; i++)
            {
                int currentNum = inputList[i];
                if (currentNum == inputList[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        longestNumSec = inputList[i];
                    }
                }

                else
                {
                    count = 1;
                }
            }

            if (longestNumSec == 0)
            {
                Console.WriteLine(inputList[0]);
            }

            else
            {

                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write("{0} " ,longestNumSec);
                }

                Console.WriteLine();
            }
        }
    }
}
