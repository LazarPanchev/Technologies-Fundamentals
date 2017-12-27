

namespace ExchangeVariableValues
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int firstNum = 5;
            int secondNum = 10;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", firstNum);
            Console.WriteLine("b = {0}", secondNum);
            int reminder = firstNum; 
            firstNum=secondNum;
            secondNum=reminder; 
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}",firstNum);
            Console.WriteLine("b = {0}", secondNum);
            

        }
    }
}
