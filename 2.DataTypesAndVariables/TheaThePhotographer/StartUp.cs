

namespace TheaThePhotographer
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double aaa = NewMethod();
            int monkey = int.Parse(Console.ReadLine());
            int filterFactorPercentage = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            int totalFilteringTime = aaa * monkey;
            int  = Math.Ceiling(aaa * (filterFactorPercentage * 0.01));
            int uploadFilteredPics = (int)usefullPics * uploadTime;
            int gogogogog = uploadFilteredPics + totalFilteringTime;

            int days = 0;
            int hours = 0;
            int minutes = 0;
            while (gogogogog > 59)
            {
                if (gogogogog >= 86400)
                {
                    days++;
                    gogogogog -= 86400;

                }
                else if (gogogogog >= 3600)
                {
                    hours++;
                    gogogogog -= 3600;

                }
                else if (gogogogog >= 60)
                {
                    minutes++;
                    gogogogog -= 60;
                }

            }
            int seconds = gogogogog;

            Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, minutes, seconds);
        }

        private static double NewMethod()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
