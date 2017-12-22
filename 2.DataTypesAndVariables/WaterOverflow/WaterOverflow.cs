

namespace WaterOverflow
{
    using System;
    public class WaterOverflow
    {

        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            int capacity = 255;
            int totalLiters = 0;
            int waterInTank = 0;
            for (int i = 0; i <lines; i++)
            {
                int waterQuantity = int.Parse(Console.ReadLine());
                totalLiters += waterQuantity;
                int waterNeedToFill = capacity - waterInTank;
                if (totalLiters<=capacity)
                {
                    waterInTank += waterQuantity;
                }
                else if(waterQuantity<= waterNeedToFill)
                {
                    waterInTank += waterQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                
                
            }
            Console.WriteLine(waterInTank);
        }
    }
}
