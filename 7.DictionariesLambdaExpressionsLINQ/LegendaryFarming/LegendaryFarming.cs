using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            Dictionary<string,int> dictionary = new Dictionary<string, int>
            {
                ["shards"] = 0,
                ["fragments"] = 0,
                ["motes"] = 0 
            };

            Dictionary<string, int> dictJunks = new Dictionary<string, int>();

            string input = Console.ReadLine();
            string winner = string.Empty;
            bool hasWinner = false;
            while (true)
            {
                string[] tokens = input.Split(' ');
                int quantity = 0;
                string material = string.Empty;

                if (hasWinner == true)
                {
                    break;
                }
                for (int i = 0; i < tokens.Length; i += 2)
                {
                    quantity = int.Parse(tokens[i]);                                                                                                                                          // Dragonwrath – requires 250 Motes;
                    material = tokens[i + 1].ToLower();

                    if (material == "shards")
                    {
                        dictionary["shards"] += quantity;

                        if (dictionary["shards"] >= 250)
                        {
                            winner = "Shadowmourne";
                            hasWinner = true;
                            dictionary["shards"] -= 250;
                            break;
                        }
                    }

                    else if (material == "fragments")
                    {
                        dictionary["fragments"] += quantity;

                        if (dictionary["fragments"] >= 250)
                        {
                            winner = "Valanyr";
                            hasWinner = true;
                            dictionary["fragments"] -= 250;
                            break;
                        }
                    }

                    else if (material == "motes")
                    {
                        dictionary["motes"] += quantity;

                        if (dictionary["motes"] >= 250)
                        {
                            winner = "Dragonwrath";
                            hasWinner = true;
                            dictionary["motes"] -= 250;
                            break;
                        }
                    }

                    else
                    {
                        if (!dictJunks.ContainsKey(material))
                        {
                            dictJunks[material] = 0;
                        }

                        dictJunks[material] += quantity;
                    }
                }

                if (hasWinner == false)
                {
                    input = Console.ReadLine();
                }

            }

            Console.WriteLine("{0} obtained!", winner);
            foreach (KeyValuePair<string,int> pair in dictionary.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                string material = pair.Key;
                int materialQuantity = pair.Value;
                Console.WriteLine("{0}: {1}", material, materialQuantity);
            }

            foreach (KeyValuePair<string,int> pair in dictJunks.OrderBy(x=>x.Key))
            {
                string junk = pair.Key;
                int junkQuantity = pair.Value;
                Console.WriteLine("{0}: {1}", junk, junkQuantity);
            }
        }
    }
}
