using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

public class CountWorkingDays
{
    public static void Main()
    {

        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(firstInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(secondInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        DateTime[] officialHolidays =
        {
            DateTime.ParseExact("01-01-1900","dd-MM-yyyy",CultureInfo.InvariantCulture),
            DateTime.ParseExact("03-03-1900","dd-MM-yyyy",CultureInfo.InvariantCulture),
            DateTime.ParseExact("01-05-1900","dd-MM-yyyy",CultureInfo.InvariantCulture),
            DateTime.ParseExact("06-05-1900","dd-MM-yyyy",CultureInfo.InvariantCulture),
            DateTime.ParseExact("24-05-1900","dd-MM-yyyy",CultureInfo.InvariantCulture),
            DateTime.ParseExact("06-09-1900","dd-MM-yyyy",CultureInfo.InvariantCulture),
            DateTime.ParseExact("22-09-1900","dd-MM-yyyy",CultureInfo.InvariantCulture),
            DateTime.ParseExact("01-11-1900","dd-MM-yyyy",CultureInfo.InvariantCulture),
            DateTime.ParseExact("24-12-1900","dd-MM-yyyy",CultureInfo.InvariantCulture),
            DateTime.ParseExact("25-12-1900","dd-MM-yyyy",CultureInfo.InvariantCulture),
            DateTime.ParseExact("26-12-1900","dd-MM-yyyy",CultureInfo.InvariantCulture)
        };
        int counter = 0;

        for (DateTime currdate = firstDate; currdate <= secondDate; currdate = currdate.AddDays(1))
        {
            bool isWeekend = false;
            bool isHoliday = false;
            if ((currdate.DayOfWeek == DayOfWeek.Saturday || currdate.DayOfWeek == DayOfWeek.Sunday))
            {
                isWeekend = true;
            }

            for (int i = 0; i < officialHolidays.Length; i++)
            {
                if (officialHolidays[i].Day == currdate.Day && officialHolidays[i].Month == currdate.Month)
                {
                    isHoliday = true;
                }
            }

            if (!isWeekend && !isHoliday)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}