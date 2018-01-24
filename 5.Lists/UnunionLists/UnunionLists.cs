namespace UnunionLists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class UnunionLists
    {
        public static void Main()
        {
            List<int> primalList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int NLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < NLines; i++)
            {
                List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for (int j = 0; j < input.Count; j++)
                {
                    int currentNum = input[j];
                    if (primalList.Contains(currentNum))
                    {
                        while (primalList.Contains(input[j]))
                        {
                            primalList.Remove(input[j]);
                        }
                    }

                    else 
                    {
                        primalList.Add(input[j]);
                    }
                }
            }

            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));

        }
    }
}
