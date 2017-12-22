
namespace DecryptingMassage
{
    using System;
    public class DecryptingMassage
    {
        public static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int nLines = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < nLines; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());
                int newChar = inputChar + key;
                result += (char)newChar;
                
            }
            Console.WriteLine(result);
        }
    }
}
