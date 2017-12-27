
namespace TrickyStrings
{
    using System;
    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int nLines = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < nLines; i++)
            {
                
                string input = Console.ReadLine();
                if(i == nLines - 1)
                {
                    result += input;
                    break;
                }
                result += input + delimiter;
            }
            
            Console.WriteLine(result);
        }
    }
}
