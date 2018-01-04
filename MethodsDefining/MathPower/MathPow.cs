namespace MathPower
{
    using System;
    public class MathPow
    {
        public static void Main()
        {
            double baseNum = double.Parse(Console.ReadLine());
            int powNum = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerNum(baseNum,powNum));
        }
        public static double PowerNum(double baseNum,int powNum)
        {
            double result = 1;
            for (int i = 0; i <powNum; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}
