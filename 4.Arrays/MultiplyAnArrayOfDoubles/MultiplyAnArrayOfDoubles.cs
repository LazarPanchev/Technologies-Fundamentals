namespace MultiplyAnArrayOfDoubles
{
    using System;
    using System.Linq;

    public class MultiplyAnArrayOfDoubles
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            double multiply = double.Parse(Console.ReadLine());

            double[] arrayInput = input.Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < arrayInput.Length; i++)
            {
                arrayInput[i] *= multiply;
            }

            Console.WriteLine(String.Join(" ",arrayInput));

        }
    }
}
