namespace TearListInHalf
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class TearListInHalf
    {
        public static void Main()
        {
            List<int> inList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            for (int i = 0; i < inList.Count; i++)
            {
                if (i < inList.Count / 2) list2.Add(inList[i]);

                else list1.Add(inList[i]);
            }

            List<int> resList = new List<int>();

            for (int i = 0; i < list1.Count; i++)
            {
                resList.Add(list1[i] / 10);
                resList.Add(list2[i]);
                resList.Add(list1[i] % 10);
            }

            Console.WriteLine(string.Join(" ", resList));
        }
    }
}
