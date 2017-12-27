
namespace SpecialNumbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int currN = 1; currN <=num; currN++)
            {
                int sumDigits = 0;
                int calculatingNum = currN;

                while (calculatingNum > 0)
                {
                    int lastDigit = calculatingNum% 10;
                    calculatingNum /= 10;
                    sumDigits += lastDigit;
                }
                bool specialNumber = ((sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11));
                
                Console.WriteLine($"{currN} -> {specialNumber}");
                
            }
        }
    }
}
