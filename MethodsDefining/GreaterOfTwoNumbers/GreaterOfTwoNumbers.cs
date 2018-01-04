namespace GreaterOfTwoNumbers
{
    using System;
    public class GreaterOfTwoNumbers
    {
        public static void Main()
        {
            string typeData = Console.ReadLine();
            if(typeData=="int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int biggerNum = GetMax(firstNum, secondNum);
                Console.WriteLine(biggerNum);
            }
            else if(typeData=="char")
            {
                char firstLetter = char.Parse(Console.ReadLine());
                char secondLetter = char.Parse(Console.ReadLine());
                char biggerCharInAscii = GetMax(firstLetter, secondLetter);
                Console.WriteLine(biggerCharInAscii);
            }
            else if(typeData=="string")
            {
                string firstName = Console.ReadLine();
                string secondName = Console.ReadLine();
                string biggerString = GetMax(firstName, secondName);
                Console.WriteLine(biggerString);
            }
            
        }
        public static int GetMax(int firstNum,int secondNum)
        {
            if (firstNum >=secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
        public static char GetMax(char firstLetter, char secondLetter)
        {
            if (firstLetter>=secondLetter)
            {
                return firstLetter;
            }
            else
            {
                return secondLetter;
            }
        }
        public static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString)>=0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
