using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SrubskoUnleashed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, int[]>> dictionaryArmy = new Dictionary<string, SortedDictionary<string, int[]>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string type = input[0];
                string name = input[1];
                int damage = 45;
                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }

                int health = 250;
                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }

                int armor = 10;
                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }

                if (!dictionaryArmy.ContainsKey(type))
                {
                    dictionaryArmy.Add(type, new SortedDictionary<string, int[]>());
                }

                if (!dictionaryArmy[type].ContainsKey(name))
                {
                    dictionaryArmy[type][name] = new int[3];
                }

                dictionaryArmy[type][name][0] = damage;
                dictionaryArmy[type][name][1] = health;
                dictionaryArmy[type][name][2] = armor;
            }

            foreach (KeyValuePair<string,SortedDictionary<string,int[]>> pair in dictionaryArmy)
            {
                string typeDragon = pair.Key;
                SortedDictionary<string, int[]> stats = pair.Value;
                double damage = stats.Select(x => x.Value[0]).Average();
                double health = stats.Select(x => x.Value[1]).Average();
                double armor = stats.Select(x => x.Value[2]).Average();
                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})",
                    typeDragon, damage, health, armor);
         
                foreach (KeyValuePair<string,int[]> secondpair in stats)
                {
                    string nameDragon = secondpair.Key;
                    int[] currentStats = secondpair.Value;
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}",
                        nameDragon,
                        currentStats[0],
                        currentStats[1],
                        currentStats[2]);
                }
            }
        }
    }
}

