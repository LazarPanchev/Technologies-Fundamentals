
namespace Calculator
{
    using System;
    public class Calculator
    {
        public static void Main()
        {
            int firstOperand = int.Parse(Console.ReadLine());
            char operatorSign = char.Parse(Console.ReadLine());
            int secondOperand = int.Parse(Console.ReadLine());
            double result = 0;
            switch(operatorSign)
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;
                case '-':
                    result = firstOperand - secondOperand;
                    break;
                case '*':
                    result = firstOperand * secondOperand;
                    break;
                case '/':
                    result = firstOperand / secondOperand;
                    break;
                case '%':
                    result = firstOperand % secondOperand;
                    break;
            }
            Console.WriteLine($"{firstOperand} {operatorSign} {secondOperand} = {result}");
           
        }
    }
}
