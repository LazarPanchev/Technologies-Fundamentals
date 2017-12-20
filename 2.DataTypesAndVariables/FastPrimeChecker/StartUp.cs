

namespace FastPrimeChecker
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int range= int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum<= range;currentNum ++)
            {
                bool prime = true;
                for (int divider = 2; divider<= Math.Sqrt(currentNum); divider++)
                {
                    if (currentNum % divider== 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {prime}");
            }

        }
    }
}
