namespace proba
{
    using System;
    public class Program
    {

        public static void Main()
        {
            int inputNUmber = int.Parse(Console.ReadLine());
            PrintTriangle(inputNUmber);
        }
        public static void PrintTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                PrintMiddle(i);
            }
            for (int i = num - 1; i >= 1; i--)
            {
                PrintMiddle(i);
            }
        }
        public static void PrintMiddle(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

    }
}
