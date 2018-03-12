using System;
using System.Text;
using System.Numerics;
using System.Linq;

namespace ConvertFromBaseNtoBase10
{
    public class ConvertFromBaseNtoBase10
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            int baseNumber =int.Parse(input[0]);
            var number = input[1];
            var numberReversed = number.ToString().Reverse().ToArray();
            BigInteger result = 0;
            
            for (int i = 0; i < numberReversed.Length; i++)
            {
                result += int.Parse(numberReversed[i].ToString()) * BigInteger.Pow(baseNumber, i);
            }

            Console.WriteLine(result);
          
        }
    }
}
