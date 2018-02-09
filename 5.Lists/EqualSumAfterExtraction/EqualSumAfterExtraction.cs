namespace EqualSumAfterExtraction
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            List<int> numbersForRemove = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> numbersForCheck = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();

            for (int i = 0; i < numbersForRemove.Count; i++)
            {
                while(numbersForCheck.Contains(numbersForRemove[i]))
                {
                    numbersForCheck.Remove(numbersForRemove[i]);
                }
            }

            
            int sumFirstList = SumNumbersInList(numbersForRemove);
            int sumSecondList = SumNumbersInList(numbersForCheck);

            if(sumFirstList==sumSecondList)
            {
                Console.WriteLine("Yes. Sum: {0}", sumFirstList);
            }

            else
            {
                int difference = Math.Abs(sumFirstList - sumSecondList);
                Console.WriteLine("No. Diff: {0}", difference);
            }
        }

        public static int SumNumbersInList(List<int> numbersList)
        {
            int sum = 0;
            foreach(var number in numbersList)
            {
                sum += number;
            }

            return sum;
        }
    }
}
