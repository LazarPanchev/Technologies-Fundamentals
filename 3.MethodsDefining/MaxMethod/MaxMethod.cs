namespace MaxMethod
{
    using System;
    public class MaxMethod
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int maxNumber = GetMax(firstNumber, secondNumber);
            Console.WriteLine(GetMax(maxNumber, thirdNumber));
        }

        public static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
