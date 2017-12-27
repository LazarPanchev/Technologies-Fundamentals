
namespace AsciiString
{
    using System;
    public class AsciiString
    {
        public static void Main()
        {
            int nLines = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < nLines; i++)
            {
                int inputChar = int.Parse(Console.ReadLine());
                char convertetToChar = (char)inputChar;
                result += convertetToChar;
            }
            Console.WriteLine(result);
        }
    }
}
