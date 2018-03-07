using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace Weather
{
    public class WeatherInfo
    {
        public double AverageTemperature { get; set; }
        public string Weather { get; set; }
    }
    class Weather
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[A-Za-z]+)\|");
            var cities = new Dictionary<string, WeatherInfo>();
            var line = Console.ReadLine();
            while (line != "end")
            {
                var weatherMatch = regex.Match(line);
                if (!weatherMatch.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }
                var city = weatherMatch.Groups["city"].Value;
                var averageTemp = double.Parse(weatherMatch.Groups["temp"].Value);
                var weather = weatherMatch.Groups["weather"].Value;

                var weatherInfo = new WeatherInfo
                {
                    AverageTemperature = averageTemp,
                    Weather = weather

                };

                cities[city] = weatherInfo;

                line = Console.ReadLine();
            }

           // var sortedCities = cities.OrderBy(a => a.Value.AverageTemperature).ToDictionary(a => a.Key, a => a.Value);

            foreach (var cityInfo in cities.OrderBy(x=>x.Value.AverageTemperature))
            {
                var city = cityInfo.Key;
                var weatherInfo = cityInfo.Value;
                Console.WriteLine($"{city} => {weatherInfo.AverageTemperature:F2} => {weatherInfo.Weather}");
            }



        }
    }
}
