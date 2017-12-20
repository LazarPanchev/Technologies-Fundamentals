
namespace TheaThePhotographer
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            long totalPics = long.Parse(Console.ReadLine());
            long filterTimeInSec = long.Parse(Console.ReadLine());
            long filterFactorPercentage = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

           double totalFilteringTime = totalPics * filterTimeInSec;
           double usefullPics = Math.Ceiling(totalPics * (filterFactorPercentage * 0.01));
           double uploadFilteredPics = usefullPics * uploadTime;
           double totalTime = uploadFilteredPics + totalFilteringTime;

            TimeSpan dateFormat = TimeSpan.FromSeconds(totalTime);
            string allTime = dateFormat.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(allTime);
            
        }
    }
}
