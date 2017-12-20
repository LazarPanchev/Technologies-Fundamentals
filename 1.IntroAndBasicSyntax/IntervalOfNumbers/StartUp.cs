
namespace IntervalOfNumbers
{
    using System;
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int  startNum = Math.Min(firstNum,secondNum);
            int endNum = Math.Max(firstNum, secondNum);
            for (int i =startNum; i <=endNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
