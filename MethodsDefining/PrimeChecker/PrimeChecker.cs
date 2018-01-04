namespace PrimeChecker
{
    using System;
    public class PrimeChecker
    {
        public static void Main()
        {
            long inputNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(inputNumber));
        }

        public static bool IsPrime(long number)
        {
            if(number<2)
            {
                return false;
            }
            for (int i = 2; i <=Math.Sqrt(number); i++)
            {
                if(number%i==0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
