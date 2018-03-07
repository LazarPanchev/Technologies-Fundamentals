using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace DayOfWeek
{
    public class Program
    {
        public static void Main()
        {
            string dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
