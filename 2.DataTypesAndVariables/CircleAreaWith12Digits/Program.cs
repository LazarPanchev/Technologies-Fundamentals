
namespace CircleAreaWith12Digits
{
    using System;
    public class Program
    {
        private static void Main(string[] args)
        {
            decimal radius = decimal.Parse(Console.ReadLine());
            decimal area = radius * radius * (decimal)Math.PI;
            Console.WriteLine("{0:F20}",area);
        }
    }
}
