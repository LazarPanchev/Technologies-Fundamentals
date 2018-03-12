using System;
using System.Text;
using System.Linq;

namespace MultiplyBigNUmbers
{
    class MultiplyBigNumbers
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int digit = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            var multilpayer = 0;
            var numberToAppend = 0;
            var reminder = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                multilpayer = (number[i] - 48) * digit + reminder;
                numberToAppend = multilpayer % 10;
                sb.Append(numberToAppend);
                reminder = multilpayer / 10;

                if (i == 0 && reminder > 0)
                {
                    sb.Append(reminder);
                }
            }

            if(digit==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(new string(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
            }
            
        }

    }
}

