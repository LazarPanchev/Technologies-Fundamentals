using System;
using System.Linq;
using System.Text;
namespace SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();

            if(firstNum.Length > secondNum.Length)
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }

            StringBuilder sb = new StringBuilder();
            var sum = 0;
            var number = 0;
            var reminder = 0;

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                sum = firstNum[i] - 48 + secondNum[i] - 48 + reminder;
                number = sum % 10;
                sb.Append(number);
                reminder = sum / 10;

                if(i==0&& reminder>0)
                {
                    sb.Append(reminder);    
                }
            }

            Console.WriteLine(new string(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
        }
    }
}
