namespace TemperatureConversion
{
    using System;
    public class TemperatureConversion
    {
        public static void Main()
        {
            double tempFahrenheit = double.Parse(Console.ReadLine());
            double tempCelsius = TemperatureConvert(tempFahrenheit);
            Console.WriteLine("{0:F2}",tempCelsius);

        }
        public static double TemperatureConvert(double tempFahrenheit)
        {
            return ((tempFahrenheit - 32) * 5 / 9); 
        }

    }
}
