using System;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDays = int.Parse(Console.ReadLine());
            int numberOfRunners = int.Parse(Console.ReadLine());
            int averagelapsForRunners = int.Parse(Console.ReadLine());
            int lengthOfTheTrack = int.Parse(Console.ReadLine());
            int capacityTrack = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            //long realRunners = marathonDays * capacityTrack;
            long possibleRunners = capacityTrack * marathonDays;
            long totalMeters = Math.Min(numberOfRunners, possibleRunners) * averagelapsForRunners * lengthOfTheTrack;
            decimal totalInKilometer = totalMeters / 1000M;
            decimal totalMoney = totalInKilometer * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:F2}");

        }
    }
}
