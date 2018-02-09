namespace SquareNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class SquareNumbers
    {
        public static void Main()
        {


            List<int> inputNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            foreach (var num in inputNums)
            {
                if (IsSquareNumber(num))
                {
                    result.Add(num);
                }
            }
            result.Sort();
            result.Reverse();

            Console.WriteLine(String.Join(" ", result));
        }

        private static bool IsSquareNumber(int num)
        {
            double result = Math.Sqrt(num);
            if (result == (int)result)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

