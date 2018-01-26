using System;
using System.Linq;
using System.Collections.Generic;

namespace Batteries
{
    class Batteries
    {
        public static void Main()
        {
            double[] batteryCapacities = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            double[] usagePerHour = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            int stresstestLast = int.Parse(Console.ReadLine());
            double[] batteryCopy = batteryCapacities.ToArray();

            for (int j = 0; j <batteryCapacities.Length; j++)
            {
                int count = 0;
                for (int i = 0; i < stresstestLast; i++)
                {
                    if (batteryCapacities[j] > 0)
                    {
                        count++;
                    }
                    batteryCapacities[j] -= usagePerHour[j];
                    
                }

                double percentage = (batteryCapacities[j] / batteryCopy[j]) * 100;

                if (batteryCapacities[j] > 0)
                {
                    Console.WriteLine("Battery {0}: {1:F2} mAh ({2:F2})%", j+1, batteryCapacities[j], percentage);
                }

                else
                {
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", j+1, count);
                }
            }
        }
    }
}
