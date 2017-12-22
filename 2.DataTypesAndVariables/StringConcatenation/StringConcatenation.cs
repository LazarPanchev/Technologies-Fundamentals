
namespace StringConcatenation
{
    using System;
    public class StringConcatenation
    {
        public static void Main()
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int numberLines = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 1; i <=numberLines; i++)
            {
                string words = Console.ReadLine();
                if(evenOrOdd=="even")
                {
                    if(i%2==0)
                    {
                        result += words + delimiter;
                    }
                    
                }
                else
                {
                    if(i%2!=0)
                    {
                        result += words + delimiter;
                    }
                }
                
            }
            result=result.Remove(result.Length - 1, 1);
            Console.WriteLine(result);
        }
    }
}
