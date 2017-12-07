using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            string drink = string.Empty;
            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    price = 1.00;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    price = 1.70;
                    break;
                default:
                    drink = "Tea";
                    price = 1.20;
                    break;

            }
            Console.WriteLine("The {0} has to pay {1:F2}.", profession,quantity*price);
        }
    }
}
