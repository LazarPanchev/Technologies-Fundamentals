using System;

namespace hORNETwINGS
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distanceFor1000Meters = double.Parse(Console.ReadLine());
            long hornetEndurance = long.Parse(Console.ReadLine());

            double distance = (wingFlaps / 1000.0) * distanceFor1000Meters;
            long time = wingFlaps / 100;
            long secTime = (wingFlaps / hornetEndurance) * 5;
            long totalTime = time + secTime;
            Console.WriteLine("{0:F2} m.",distance);
            Console.WriteLine("{0} s.",totalTime);

        }
    }
}
