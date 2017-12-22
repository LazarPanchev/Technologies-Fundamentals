
namespace MakeAWord
{
    using System;
    
    public class MakeAWord
    {
        public static void Main()
        {
            int nLines = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < nLines; i++)
            {
                char input=char.Parse(Console.ReadLine());

                result += input;
                

            }
            Console.WriteLine("The word is: "+result);
        }
    }
}
