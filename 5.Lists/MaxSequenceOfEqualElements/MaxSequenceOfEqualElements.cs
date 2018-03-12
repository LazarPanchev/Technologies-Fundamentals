namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(int.Parse)
                .ToList();
            int count = 1;
            int maxCount = 0;
            int maxOccurrencesNum = 0;

            for (int i = 0; i < nums.Count-1; i++)
            {
                int currentNum = nums[i];

                if (currentNum == nums[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxOccurrencesNum = currentNum;
                    }
                }

                else
                {
                    count = 1;
                }
            }

            if(maxOccurrencesNum==0)
            {
                Console.WriteLine(nums[0]);
            }

            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write("{0} ", maxOccurrencesNum);
                }

                Console.WriteLine();
            }
        }
    }
}
