namespace MasterNumbers
{
    using System;

    public class MasterNumbers
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 1; i <=range; i++)
            {
                if (SumOfDigits(i) && IsPalindrome(i.ToString()) && ContainsEvenDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool SumOfDigits(int number)
        {
            int sumDigits = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                sumDigits += lastDigit;
                number /= 10;
            }
            if (sumDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPalindrome(string number)
        {
            bool isSymmetric = false;
            string reversedNumber = string.Empty;
            for (int i = number.Length-1 ; i >= 0 ; i--)
            {
                reversedNumber += number[i];
            }

            if(reversedNumber.CompareTo(number)==0)
            {
                isSymmetric = true;
            }

            return isSymmetric;
        }

        public static bool ContainsEvenDigits(int number)
        {
            bool hasEven = false;
            foreach(char symbol in number.ToString())
            {
                switch(symbol)
                {
                    case '0':
                    case '2':
                    case '4':
                    case '6':
                    case '8':
                        hasEven = true;
                        break;
                }
            }

            return hasEven;
        }

    }
}
