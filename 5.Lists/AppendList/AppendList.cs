namespace AppendList
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class AppendList
    {
        public static void Main()
        {
            

            List<string> items = Console.ReadLine()
                .Split('|')
                .ToList();

            items.Reverse();
            List<string> result = new List<string>();

            foreach (var item in items)
            {
                List<string> nums = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }

            Console.WriteLine(string.Join(" ",result));

        }
    }
}
