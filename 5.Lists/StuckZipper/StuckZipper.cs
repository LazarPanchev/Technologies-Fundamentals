namespace StuckZipper
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StuckZipper
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int minDigitNum = Math.Min(FindMinCountDigit(firstList), FindMinCountDigit(secondList)); //1

            RemoveBiggerCountDigits(firstList, minDigitNum);
            RemoveBiggerCountDigits(secondList, minDigitNum); //till here it's work perfect

            int smallerList = Math.Min(firstList.Count, secondList.Count);
            int biggerList = Math.Max(firstList.Count, secondList.Count);
            int difference = biggerList - smallerList;
            List<int> resultList = new List<int>();

            for (int i = 0; i < smallerList; i++)
            {
                resultList.Add(secondList[i]);
                resultList.Add(firstList[i]);
            }

            if (difference > 0 )
            {
                int[] tempresult = new int[difference];
                if (firstList.Count == smallerList)
                {
                    tempresult = AddExtraNumbers(secondList, difference);
                }

                else
                {
                    tempresult = AddExtraNumbers(firstList, difference);
                }

              if(tempresult.Length > 1 || (firstList.Count != 0 && secondList.Count != 0))
              {
                 tempresult=tempresult.Reverse().ToArray();
              }

                resultList.AddRange(tempresult);                
            }

            Console.WriteLine(string.Join(" ", resultList));

        }

        public static int[] AddExtraNumbers(List<int> list, int difference) // possible mistake!!
        {
            int[] tempResult = new int[difference];

            for (int i = 0; i < difference; i++)
            {
                tempResult[i] = list[list.Count - 1 - i];
            }

            return tempResult;
        }

        public static List<int> RemoveBiggerCountDigits(List<int> list, int minDigitNum)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (CountDigits(list[i]) > minDigitNum)
                {
                    int numberForRemove = list[i];
                    while (list.Contains(numberForRemove))
                    {
                        list.Remove(numberForRemove);
                        i--;
                    }

                }
            }

            return list;
        }

        public static int FindMinCountDigit(List<int> list)
        {
            int minCount = int.MaxValue;
            foreach (int number in list)
            {
                int currentNum = CountDigits(number);
                if (currentNum < minCount)
                {
                    minCount = currentNum;
                }
            }

            return minCount;
        }

        public static int CountDigits(int number)
        {
            number = Math.Abs(number);
            int countDigits = 0;
            while (number > 0)
            {
                countDigits++;
                number /= 10;
            }

            return countDigits;
        }

    }
}
