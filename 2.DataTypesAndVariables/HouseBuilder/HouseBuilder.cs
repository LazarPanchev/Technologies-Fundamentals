
namespace HouseBuilder
{
    using System;
    public class HouseBuilder
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sbyteNum = 0;
            long intNum = 0L;
            if(firstNumber>=sbyte.MinValue && firstNumber<=sbyte.MaxValue)
            {
                sbyteNum =firstNumber*4;
                intNum = secondNumber*10L;
            }
            else
            {
                sbyteNum = secondNumber*4;
                intNum = firstNumber*10L;
            }
            long sum = sbyteNum + intNum;
            Console.WriteLine(sum);
        }
    }
}
