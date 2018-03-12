using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace TestDemo
{
    public class ConvertingFromBase10ToBaseN
    {
        public static void Main()
        {

            BigInteger[] nums = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger baseN = nums[0];
            BigInteger numIn10base = nums[1];
            string result = string.Empty;
            BigInteger remain = 0;
            while (numIn10base > 0)
            {
                remain = numIn10base % baseN;
                result = remain.ToString() + result;
                (numIn10base) /= baseN;
            }


            Console.WriteLine(result);

        }
    }
}
