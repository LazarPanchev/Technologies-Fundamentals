

namespace CaloriesCounter
{
    using System;
    class Program
    {
        static void Main()
        {
            int pizzaIngredients = int.Parse(Console.ReadLine());
            int calories = 0;
            int totalCheeseCal = 0;
            int totalTomatoCal = 0;
            int totalSalamiCal = 0;
            int totalPepperCal = 0;
            for (int i = 0; i < pizzaIngredients; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    totalCheeseCal += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    totalTomatoCal += 150;
                }
                else if (ingredients == "salami")
                {
                    totalSalamiCal+= 600;
                }
                else if (ingredients == "pepper")
                {
                    totalPepperCal +=50;
                }
                
            }
            int totalCalories = totalCheeseCal + totalTomatoCal + totalSalamiCal + totalPepperCal;
            Console.WriteLine("Total calories: {0}",totalCalories);
        }
    }
}
