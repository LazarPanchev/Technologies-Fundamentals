
namespace BalancedBrackets
{
    using System;
    public class BalancedBrackets
    {
        public static void Main()
        {
            int nLines = int.Parse(Console.ReadLine());
            string lastParenthese = string.Empty;
            bool balancedParenthese = true;
            for (int i = 0; i < nLines; i++)
            {
                string inputString = Console.ReadLine();
                if(inputString=="(")
                {
                    if(lastParenthese=="(")
                    {
                        balancedParenthese = false;
                    }
                    lastParenthese = "(";
                }
                if(inputString==")")
                {
                    if(lastParenthese!="(")
                    {
                        balancedParenthese = false;
                    }
                    lastParenthese = ")";
                }     
            }
            if (lastParenthese == "(")
            {
                balancedParenthese = false;
            }
            if (balancedParenthese)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
