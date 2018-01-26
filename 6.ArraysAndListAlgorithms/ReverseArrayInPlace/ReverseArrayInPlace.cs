namespace ReverseArrayInPlace
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class ReverseArrayInPlace
    {
        public static void Main()
        {
            List<int> inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < inputArray.Count/2; i++)
            {
                int temporary = inputArray[i];
                int oposite = inputArray[inputArray.Count - 1 - i];
                inputArray[i] = oposite;
                inputArray[inputArray.Count - 1 - i] = temporary;
            }

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
