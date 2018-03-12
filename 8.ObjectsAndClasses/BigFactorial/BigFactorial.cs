using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace BigFactorial
{
    public class BigFactorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger f = 1;
            for (int i = 2; i <=n; i++)
            {
                f *= i;
            }

            Console.WriteLine(f);
        }
    }
}
