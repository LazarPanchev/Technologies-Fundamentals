
namespace BlankReceipt
{
    using System;
    public class Program
    {
        public static void Main()
        {
            PrintReceipt();
        }
        public static void PrintReceipt()
        {
            PrintHeather();
            PrintBody();
            PrintFooter();

        }
        public static void PrintHeather()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        public static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        public static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
