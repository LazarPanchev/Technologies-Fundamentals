using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double masterSuitePrice = 0.0;
            double discount = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                masterSuitePrice = 75;
                if (nights > 7)
                {
                    studioPrice -= (0.05 * studioPrice);
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                masterSuitePrice = 82;
                if (nights > 14)
                {
                    doublePrice -= (0.10 * doublePrice);
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                masterSuitePrice = 89;
                if (nights > 14)
                {
                    masterSuitePrice -= (0.15 * masterSuitePrice);
                }
            }
            if ((month == "September" || month == "October") && nights > 7)
            {
                Console.WriteLine("Studio: {0:F2} lv.", studioPrice * (nights-1));
                Console.WriteLine("Double: {0:F2} lv.", doublePrice * nights );
                Console.WriteLine("Suite: {0:F2} lv.", masterSuitePrice * nights);
            }
            else
            {
                Console.WriteLine("Studio: {0:F2} lv.", studioPrice * nights);
                Console.WriteLine("Double: {0:F2} lv.", doublePrice * nights);
                Console.WriteLine("Suite: {0:F2} lv.", masterSuitePrice * nights);
            }


        }
    }
}
