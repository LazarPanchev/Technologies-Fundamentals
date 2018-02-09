namespace SortNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SortNumbers
    {
        public static void Main()
        {
            List<decimal> numbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ",numbers));

        }
    }
}
