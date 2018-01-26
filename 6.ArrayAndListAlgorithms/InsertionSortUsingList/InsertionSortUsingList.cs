namespace InsertionSortUsingList
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class InsertionSortUsingList
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            for (int firstIndex = 0; firstIndex < list.Count; firstIndex++)
            {
                var inserted = false;
                int elementToInsert = list[firstIndex];
                for (int secondIndex = 0; secondIndex < result.Count; secondIndex++)
                {
                    var currentListElement = result[secondIndex];
                    if(elementToInsert < currentListElement)
                    {
                        inserted = true;
                        result.Insert(secondIndex, elementToInsert);
                        break;
                    }
                }

                if(!inserted)
                {
                    result.Add(elementToInsert);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
