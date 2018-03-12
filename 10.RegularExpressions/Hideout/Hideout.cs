using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hideout
{
    class Hideout
    {
        static void Main()
        {
            string map = Console.ReadLine();
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            bool foundHideOut = false;
            while (!foundHideOut)
            {
                string[] clues = input.Split(' ');
                string searchedChar = clues[0];
                int minimumCount = int.Parse(clues[1]);
                int index = 0;
                int count = 0;
                int maxCount = 0;
                int startIndex = 0;
                if(map.Contains(searchedChar))
                {
                    index = map.IndexOf(searchedChar);
                    for (int i = index; i < map.Length-1; i++)
                    {
                        if(map[i]==map[i+1])
                        {
                            startIndex = i;
                            count++;
                            if(count>maxCount)
                            {
                                maxCount = count;
                            }
                                               
                        }
                        else
                        {

                            if (maxCount > minimumCount)
                            {
                                Console.WriteLine($"Hideout found at index {startIndex} and it is with size {maxCount}!");
                                foundHideOut = true;
                                break;
                            }
                            startIndex = 0;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

        }
    }
}
