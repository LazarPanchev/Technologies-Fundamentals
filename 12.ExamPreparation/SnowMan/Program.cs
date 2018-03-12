using System;
using System.Collections.Generic;
using System.Linq;

namespace RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowman = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //List<int> losers = new List<int>();
            bool gameOver = false;
            while (snowman.Count != 1)
            {
                if (gameOver == true)
                {
                    break;
                }
                List<int> losers = new List<int>();
                for (int i = 0; i < snowman.Count; i++)
                {
                    if (losers.Contains(i))
                    {
                        continue;
                    }

                    if (snowman.Count - losers.Count == 1)
                    {
                        gameOver = true;
                        break;
                    }
                    int attacker = i;
                    int target = snowman[i];

                    if (snowman[i] >= snowman.Count)
                    {
                        target %= snowman.Count;
                    }

                    int difference = Math.Abs(attacker - target);

                    if (difference == 0)
                    {

                        Console.WriteLine($"{attacker} performed harakiri");
                        losers.Add(attacker);

                    }

                    else if (difference % 2 == 0)
                    {

                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        losers.Add(target);
                    }

                    else
                    {

                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        losers.Add(attacker);
                    }
                    losers = losers.Distinct().ToList();
                }

                RemoveLosers(snowman, losers);
            }
        }

        private static void RemoveLosers(List<int> snowman, List<int> losers)
        {
            foreach (var index in losers.OrderByDescending(x => x))//.Distinct())
            {
                snowman.RemoveAt(index);
            }

            losers.Clear();
        }
    }
}
