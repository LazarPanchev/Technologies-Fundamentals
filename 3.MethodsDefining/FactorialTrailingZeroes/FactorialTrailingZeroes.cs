namespace FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(inputNumber);
            long countZeroes = ContainsZeroes(factorial.ToString());
            Console.WriteLine(countZeroes);
        }

        public static long ContainsZeroes(string factorial)
        {
            long countZeroes = 0;

            for (int i = factorial.Length - 1; i >= 0; i--)
            {
                if(factorial[i]!='0' && countZeroes>0)
                {
                    break;
                }

                if (factorial[i] == '0')
                {
                    countZeroes++;
                }
            }

            return countZeroes;
        }

        public static BigInteger CalculateFactorial(int inputNumber)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= inputNumber; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

    }
}
