namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
<<<<<<< HEAD
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
=======
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
>>>>>>> 84d03160caa7d23570767b816c70d87d2f40459c
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
<<<<<<< HEAD
                        maxOccurrencesNum = currentNum;
=======
                        longestNumSec = inputList[i];
>>>>>>> 84d03160caa7d23570767b816c70d87d2f40459c
                    }
                }

                else
                {
                    count = 1;
                }
            }

<<<<<<< HEAD
            if(maxOccurrencesNum==0)
            {
                Console.WriteLine(nums[0]);
=======
            if (longestNumSec == 0)
            {
                Console.WriteLine(inputList[0]);
>>>>>>> 84d03160caa7d23570767b816c70d87d2f40459c
            }

            else
            {
<<<<<<< HEAD
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write("{0} ", maxOccurrencesNum);
=======

                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write("{0} " ,longestNumSec);
>>>>>>> 84d03160caa7d23570767b816c70d87d2f40459c
                }

                Console.WriteLine();
            }
        }
    }
}
