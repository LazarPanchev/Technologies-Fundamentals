

namespace IntegerToHexAndBinary
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string convertedToHexadecimal = Convert.ToString(number, 16);
            string convertedToBinary = Convert.ToString(number, 2);
            Console.WriteLine(convertedToHexadecimal.ToUpper());
            Console.WriteLine(convertedToBinary);
        }
    }
}
