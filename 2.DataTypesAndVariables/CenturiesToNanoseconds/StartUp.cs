

namespace CenturiesToNanoseconds
{
    using System;
    using System.Numerics;
    public class StartUp
    {
        public static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = minutes * 60L;
            ulong milliseconds = (ulong)seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries,years,days,hours,minutes,seconds,milliseconds,microseconds,nanoseconds);




        }
    }
}
