using System;
using System.Globalization;

namespace CoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < nLines; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());

                decimal currentPrice = (DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsulesCount) * price;
                totalPrice += currentPrice;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");

            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
