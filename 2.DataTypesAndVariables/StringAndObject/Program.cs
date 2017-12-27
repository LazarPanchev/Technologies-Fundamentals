
namespace StringAndObject
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string firstNme = "Hello";
            string secondName = "World";
            object total = firstNme + " " + secondName;
            string concatenation = (string)total;
            Console.WriteLine(concatenation);
        }
    }
}
