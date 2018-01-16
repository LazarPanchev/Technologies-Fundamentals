namespace Factorial
{
    using System;
    using System.Numerics;

    public class Factorial
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(inputNumber);
            Console.WriteLine(factorial);
        }

        public static BigInteger CalculateFactorial(int inputNumber)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <=inputNumber; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
