

namespace VariableInHexadecimalFormat
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            int convertedNum = Convert.ToInt32(number, 16);
            Console.WriteLine(convertedNum);

        }
    }
}
