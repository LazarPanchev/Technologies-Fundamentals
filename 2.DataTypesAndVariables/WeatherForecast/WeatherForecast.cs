
namespace WeatherForecast
{
    using System;
    public class WeatherForecast
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            try
            {
                long num = long.Parse(number);
                if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (num>=int.MinValue && num<=int.MaxValue)
                {
                    Console.WriteLine( "Cloudy");
                }
                
                else
                {
                   Console.WriteLine("Windy");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
