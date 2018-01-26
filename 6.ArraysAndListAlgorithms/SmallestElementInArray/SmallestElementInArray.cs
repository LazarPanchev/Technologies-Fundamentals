namespace SmallestElementInArray
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            List<int> inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int smallestNum = int.MaxValue;
            for (int i = 0; i < inputArray.Count; i++)
            {
                if(inputArray[i]<smallestNum)
                {
                    smallestNum = inputArray[i];
                }
            }

            Console.WriteLine(smallestNum);
        }
    }
}
