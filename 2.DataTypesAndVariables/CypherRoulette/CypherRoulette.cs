
namespace CypherRoulette
{
    using System;
    public class CypherRoulette
    {
        public static void Main()
        {
            uint nLines = uint.Parse(Console.ReadLine());
            string result = string.Empty;
            bool addToend = true;
            string lastInput = string.Empty;
            for (int i = 0; i < nLines; i++)
            {
                string input = Console.ReadLine();               
                if (input=="spin")   //spin
                {
                    i--;
                    if (input == lastInput) // spin spin
                    {
                        result = string.Empty;        //but no change addToEnd bool by task              
                    }
                    else
                    {
                        addToend = !addToend;         // if only spin - chamge addToEnd
                    }
                    lastInput = input;
                    continue; // if spin don't print only i--
                }
                if (input == lastInput)
                {
                    result = string.Empty;
                }
                else
                {
                    if (addToend)
                    {
                        result += input;
                    }
                    else
                    {
                        result = input + result;
                    }
                }
                lastInput = input;   
            }
            Console.WriteLine(result);
        }
    }
}
