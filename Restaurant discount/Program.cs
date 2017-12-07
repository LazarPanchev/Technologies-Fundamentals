using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int priceHall = 0;
            int pricePackage = 0;
            string hall = string.Empty;
            double discountPercent = 0.0;

            
            
            if(groupSize<=50)
            {
                priceHall = 2500;
                hall = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                priceHall = 5000;
                hall = "Terrace";
            }
            else if (groupSize <= 120)
            {
                priceHall = 7500;
                hall = "Great Hall";
            }
            if (package=="Normal")
            {
                pricePackage = 500;
                discountPercent= 0.05;
            }
            else if(package=="Gold")
            {
                pricePackage = 750;
                discountPercent = 0.10;
            }
            else if (package == "Platinum")
            {
                pricePackage = 1000;
                discountPercent = 0.15;
            }
            double totalPrice = priceHall + pricePackage;
            double discountForPrice = discountPercent * totalPrice;
            totalPrice -= discountForPrice;
            double pricePerPerson = totalPrice / groupSize;
            if(groupSize>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine("We can offer you the {0}",hall);
                Console.WriteLine("The price per person is {0:F2}$",pricePerPerson);
            }

        }
    }
}
