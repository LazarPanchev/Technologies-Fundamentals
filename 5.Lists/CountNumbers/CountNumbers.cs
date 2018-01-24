namespace CountNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CountNumbers
    {
        public static void Main()
        {

            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            nums.Sort();

            var start = 0;
            var len = 1;
            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1 || nums[i] != nums[i + 1])
                {
                    Console.WriteLine(nums[start] + " -> " + len);
                    start = i + 1;
                    len = 1;
                }

                else
                {
                    len++;
                }
            }         
        }
    }
}
