namespace FibonacciNumbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            int fibonacciNth = int.Parse(Console.ReadLine());
            long result = Fin(fibonacciNth);
            Console.WriteLine(result);
        }

        public static long Fin(long n)
        {
            long firstFiboNumber = 0;
            long secondFiboNumber = 1;
            long fibonacciNum = 0;
 
            for (int i = 0; i <n; i++)
            {
                fibonacciNum=firstFiboNumber;
                firstFiboNumber = secondFiboNumber;
                secondFiboNumber = fibonacciNum + firstFiboNumber;
            }

            return secondFiboNumber;
        }
    }
}
