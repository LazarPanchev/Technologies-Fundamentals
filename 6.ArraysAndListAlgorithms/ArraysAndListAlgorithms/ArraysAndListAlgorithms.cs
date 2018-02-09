namespace ArraysAndListAlgorithms
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ArraysAndListAlgorithms
    {
        public static void Main()
        {
            List<int> inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int numberForCheck = int.Parse(Console.ReadLine());
            bool isFound = false;
            for (int i = 0; i < inputArray.Count; i++)
            {
                if(inputArray[i]==numberForCheck)
                {
                    isFound = true;
                    Console.WriteLine("yes");
                    break;
                }

            }

            if(!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
