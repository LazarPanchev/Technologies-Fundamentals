namespace PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> primesInRange=(FindPrimesInRange(startNum,endNum));
            Console.WriteLine(string.Join(", ",primesInRange));
        }

        public  static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();

            for (int i = startNum; i <=endNum; i++)
            { 
                if(IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        public static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
