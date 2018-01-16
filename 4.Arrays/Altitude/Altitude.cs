namespace Altitude
{
    using System;
    using System.Linq;

    public class Altitude
    {
        public static void Main()
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();
            long currentAltitude = long.Parse(command[0]);
            bool crashed = false;
            for (long i = 1; i < command.Length-1; i += 2)
            {
                long value = long.Parse(command[i + 1]);
                switch (command[i])
                {              
                    case "up":
                        currentAltitude += value;
                        break;
                    case "down":
                        currentAltitude -= value;
                        break;
                }

                if (currentAltitude <= 0)
                {
                    crashed = true;
                    break;
                }
            }

            if (crashed)
            {
                Console.WriteLine("crashed");
            }

            else
            {
                Console.WriteLine("got through safely. current altitude: {0}m", currentAltitude);
            }
        }
    }
}
