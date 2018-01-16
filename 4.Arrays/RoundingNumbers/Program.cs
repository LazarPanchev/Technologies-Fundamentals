namespace RoundingNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int roundedDigit = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}",numbers[i], roundedDigit );
            }

           // Console.WriteLine(string.Join(" ", numbers));
        }

        
    }
}
