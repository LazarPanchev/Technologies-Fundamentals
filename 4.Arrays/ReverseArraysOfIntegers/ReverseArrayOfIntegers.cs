namespace ReverseArraysOfIntegers
{
    using System;

    public class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayNumbers[i]= int.Parse(Console.ReadLine());
            }

            for (int i = n-1; i >=0; i--)
            {
                Console.Write(arrayNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
