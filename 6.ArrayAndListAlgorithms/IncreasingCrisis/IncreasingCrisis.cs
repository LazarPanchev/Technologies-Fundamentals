using System;
using System.Linq;
using System.Collections.Generic;

namespace IncreasingCrisis
{
    public class IncreasingCrisis
    {
        public static void Main()
        {
            int nLines = int.Parse(Console.ReadLine());
            List<int> resultList = new List<int>();

            for (int i = 0; i < nLines; i++)
            {



                int[] currentNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (resultList.Count == 0)
                {
                    resultList.AddRange(currentNumbers);
                    RemoveDecrementElements(resultList);

                }

                else
                {
                    int firstDigit = currentNumbers.First();
                    int searchingIndex = FindIndexToInsert(resultList, firstDigit);
                    resultList.InsertRange(searchingIndex, currentNumbers);
                    RemoveDecrementElements(resultList);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }

        private static int FindIndexToInsert(List<int> resultList, int firstDigit)
        {
            int searchIndex = 0;
            bool foundIndex = false;
            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i] >firstDigit)
                {
                    foundIndex = true;
                    searchIndex = i;
                    break;

                }
            }

            if(!foundIndex)
            {
                searchIndex = resultList.Count;
            }

            return searchIndex;
        }

        private static void RemoveDecrementElements(List<int> resultList)
        {
            for (int i = 0; i < resultList.Count - 1; i++)
            {
                if (resultList[i] <= resultList[i + 1])
                {
                    continue;
                }

                else
                {
                    resultList.RemoveRange(i + 1, (resultList.Count - 1) - i);
                }
            }
        }
    }
}
