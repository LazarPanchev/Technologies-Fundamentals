namespace BalisticsTraining
{
    using System;
    using System.Linq;

    public class BalisticsTraining
    {
        public static void Main()
        {
            double[] planeCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            string[] firingCoordinates = Console.ReadLine().Split(' ').ToArray();

            double coordinateX = 0.0;
            double coordinateY = 0.0;

            for (int i = 0; i < firingCoordinates.Length - 1; i += 2)
            {
                string currentCommand = firingCoordinates[i];
                double currentValue = double.Parse(firingCoordinates[i + 1]);

                if (currentCommand.Equals("up"))
                {
                    coordinateY += currentValue;
                }

                else if (currentCommand.Equals("down"))
                {
                    coordinateY -= currentValue;
                }

                else if (currentCommand.Equals("left"))
                {
                    coordinateX -= currentValue;
                }

                else
                {
                    coordinateX += currentValue;
                }
            }

            Console.WriteLine($"firing at [{coordinateX}, {coordinateY}]");

            if (coordinateX == planeCoordinates[0] && coordinateY == planeCoordinates[1])
            {
                Console.WriteLine("got 'em!");
            }

            else
            {
                Console.WriteLine("better luck next time...");
            }
        }


    }
}


