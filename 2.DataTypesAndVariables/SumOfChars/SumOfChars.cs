
namespace SumOfChars
{
    using System;
    public class SumOfChars
    {
        public static void Main()
        {
            int nLines = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < nLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += (int)letter;
            }
            Console.WriteLine("The sum equals: "+ result);
        }
    }
}
