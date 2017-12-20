

namespace ConvertSpeedUnits
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float timePerHours = float.Parse(Console.ReadLine());
            float timePerMinutes = float.Parse(Console.ReadLine());
            float timePerSeconds = float.Parse(Console.ReadLine());
            float timeTotalInHour = (timePerHours) + (timePerMinutes / 60) + (timePerSeconds / 3600);
            float timeTotalInMinutes= (timePerHours * 60) + (timePerMinutes) + (timePerSeconds / 60);
            float timeTotalInSeconds = (timePerHours * 3600) + (timePerMinutes * 60) + (timePerSeconds);
            float speedMetersPerSec = distanceInMeters / timeTotalInSeconds;
            float speedKilometersPerHour = (distanceInMeters / 1000) / timeTotalInHour;
            float speedMilesPerHour = (distanceInMeters / 1609) / timeTotalInHour;
            Console.WriteLine(speedMetersPerSec);
            Console.WriteLine(speedKilometersPerHour);
            Console.WriteLine(speedMilesPerHour);
        }
    }
}
