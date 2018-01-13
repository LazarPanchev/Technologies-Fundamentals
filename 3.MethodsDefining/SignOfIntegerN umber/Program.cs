namespace SignOfIntegerNumber
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            CheckNumbers(inputNumber);
        }
        public static void CheckNumbers(int introNum)
        {
            if (introNum == 0)
            {
                Console.WriteLine("The number {0} is zero.", introNum);
            }
            else if(introNum>0)
            {
                Console.WriteLine("The number {0} is positive.", introNum);

            }
            else
            {
                Console.WriteLine("The number {0} is negative.", introNum);

            }

        }
    }
}
