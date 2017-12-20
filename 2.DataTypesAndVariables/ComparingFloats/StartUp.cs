
namespace ComparingFloats
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double differenceMax = 0.000001;
            double difference = Math.Abs(firstNum - secondNum);
            if(difference >= differenceMax)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
