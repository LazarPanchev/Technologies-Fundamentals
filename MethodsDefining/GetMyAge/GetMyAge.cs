namespace TemperatureConversion
{
    using System;
    public class GetMyAge
    {
        public static void Main()
        {
            var age = GetAge(1985, 12, 27); // for example- year, month, day
            Console.WriteLine(age);
        }
        public static int GetAge(int year, int month, int day)
        {
            DateTime now = DateTime.Now;
            int currentYear = now.Year;
            int currentMonth = now.Month;
            int currentDay = now.Day;
            int age = currentYear - year;
            if (month > currentMonth || (currentMonth == month && day > currentDay))
            {
                age--;
            }
            return age;
        }

    }
}
