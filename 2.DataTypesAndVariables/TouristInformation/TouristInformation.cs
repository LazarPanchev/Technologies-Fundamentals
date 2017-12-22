
namespace TouristInformation
{
    using System;
    public class TouristInformation
    {
        public static void Main()
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double convertedValue = 0.0;
            string metricUnit = string.Empty;
            switch(imperialUnit)
            {
                case "miles":
                    convertedValue = value * 1.6;
                    metricUnit = "kilometers";
                    break;
                case "inches":
                    convertedValue = value*2.54;
                    metricUnit = "centimeters";
                    break;
                case "feet":
                    convertedValue = value * 30;
                    metricUnit = "centimeters";
                    break;
                case "yards":
                    convertedValue = value * 0.91;
                    metricUnit = "meters";
                    break;
                case "gallons":
                    convertedValue = value * 3.8;
                    metricUnit = "liters";
                    break;

            }
            Console.WriteLine($"{value} {imperialUnit} = {convertedValue:F2} {metricUnit}");
        }
    }
}
