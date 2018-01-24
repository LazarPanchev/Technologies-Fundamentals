namespace ExtractMiddleElements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ExtractMiddleElements
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var result = ExtractMiddle(nums);
            Console.WriteLine("{ " + string.Join(", ", result) + " }");

        }

        private static int[] ExtractMiddle(int[] nums)
        {
            int len = nums.Length;
            if (len == 1)
            {
                return nums;
            }
            if (len % 2 == 0)
            {
                return new int[] { nums[len / 2 - 1], nums[len / 2] };
            }
            else
            {
                return new int[] { nums[len / 2 - 1], nums[len / 2], nums[len / 2+1] };
            }
        }
    }
}
