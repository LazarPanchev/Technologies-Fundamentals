
namespace BoatSimulator
{
    using System;
    public class BoatSimulator
    {
        public static void Main()
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int firstBoatSpeed = 0;
            int secondBoatSpeed = 0;
            int nLines = int.Parse(Console.ReadLine());
            for (int i = 1; i <=nLines; i++)
            {
                if(firstBoatSpeed>=50||secondBoatSpeed>=50)
                {
                    break;
                }
                string currentSpeed = Console.ReadLine();
                if(currentSpeed=="UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                    continue;
                }
                int addingSpeed = currentSpeed.Length;
                if(i%2!=0)
                {
                    firstBoatSpeed += addingSpeed;
                }
                else
                {
                    secondBoatSpeed += addingSpeed;
                }
            }
            if(firstBoatSpeed>secondBoatSpeed)
            {
                 Console.WriteLine(firstBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}
