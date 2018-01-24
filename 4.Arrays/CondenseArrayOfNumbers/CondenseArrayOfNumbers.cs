namespace CondenseArrayOfNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class CondenseArrayOfNumbers
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int r = 0; r < nums.Length - 1; r++)
            {


                for (int i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }


            }

            Console.WriteLine(nums[0]);
        }
    }
}
