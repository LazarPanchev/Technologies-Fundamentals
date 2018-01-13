namespace NumbersInReversedOrder
{
    using System;
    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            decimal inputNumber = decimal.Parse(Console.ReadLine());
            string result = ReversedNumber(inputNumber);
            Console.WriteLine(result);
        }

        public static string ReversedNumber(decimal number)
        {
            string result = string.Empty;
            foreach (char symbol in number.ToString())
            {
                result =symbol + result;
            }

            return result;
        }
    }
}
