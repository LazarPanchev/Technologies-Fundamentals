namespace DistinctList
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class DistinctList
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count-1; i++)
            {
                int currentNum = numbers[i];
                for (int j = i+1; j < numbers.Count; j++)
                {
                    if(currentNum==numbers[j])
                    {
                        numbers.RemoveAt(j);
                        j--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
