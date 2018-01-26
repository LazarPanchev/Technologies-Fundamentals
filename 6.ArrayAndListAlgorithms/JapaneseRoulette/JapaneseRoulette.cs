using System;
using System.Linq;
using System.Collections.Generic;

namespace JapaneseRoulette
{
    public class JapaneseRoulette
    {
        public static void Main()
        {
            int[] cylinder = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<string> players = Console.ReadLine()
                .Split(' ')
                .ToList();

            bool shootHimself = false;
            int currentIndex = 0;
            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1)
                {
                    currentIndex = i;
                    break;
                }
            }

            for (int i = 0; i < players.Count; i++)
            {
                string[] command = players[i].Split(',').ToArray();
                string direction = command[1];
                int value = int.Parse(command[0]);

                if (direction == "Right")
                {
                    currentIndex = (currentIndex + value) % cylinder.Length;

                }

                else
                {
                    if (currentIndex - value < 0)
                    {
                        currentIndex = cylinder.Length - Math.Abs(currentIndex - value) % cylinder.Length;
                    }

                    else
                    {
                        currentIndex = currentIndex - value;
                    }


                }

                if (currentIndex == 2)
                {
                    Console.WriteLine("Game over! Player {0} is dead.", i);
                    shootHimself = true;
                    break;
                }

                currentIndex = currentIndex + 1 == cylinder.Length ? 0 : currentIndex + 1;
            }



            if (!shootHimself)
            {
                Console.WriteLine("Everybody got lucky!");
            }

        }
    }
}
