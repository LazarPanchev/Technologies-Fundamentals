namespace SearchForANumber
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SearchForANumber
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] numsForCheck = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> resultList = new List<int>(numbers.Count);

            for (int i = 0; i < numsForCheck[0]; i++)
            {
                resultList.Add(numbers[i]);
            }

            for (int i = 0; i < numsForCheck[1]; i++)
            {
                resultList.Remove(resultList[0]);
                
            }

            if(resultList.Contains(numsForCheck[2]))
            {
                Console.WriteLine("YES!");
            }

            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
