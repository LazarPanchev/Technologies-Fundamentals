using System;
using System.Linq;
using System.Collections.Generic;

namespace ShootListElements
{
    public class ShootListElements
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<int> listNums = new List<int>();
            int lastRemoved = 0;
            while(input != "stop")
            {
                if(input != "bang")
                {
                    int number = int.Parse(input);
                    listNums.Insert(0, number);
                }

                else
                {
                    if (listNums.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was {0}", lastRemoved);
                        break;
                    }

                    else
                    {
                        double average = listNums.Average();

                        if (listNums.Count > 1)
                        {
                            for (int i = 0; i < listNums.Count; i++)
                            {
                                if (listNums[i] < average)
                                {
                                    lastRemoved = listNums[i];
                                    Console.WriteLine("shot {0}", lastRemoved);
                                    listNums.RemoveAt(i);
                                    DecrementElements(listNums);
                                    break;
                                }
                            }
                        }

                        else
                        {
                            lastRemoved = listNums[0];
                            Console.WriteLine("shot {0}", lastRemoved);
                            listNums.RemoveAt(0);
                        }
                    }
                    
                }

                input = Console.ReadLine();
            }

            if (listNums.Count == 0 && input=="stop")
            {
                Console.WriteLine("you shot them all. last one was {0}", lastRemoved);
            }

            else if(listNums.Count>0 && input=="stop")
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", listNums));
            }
        }

        private static void DecrementElements(List<int> listNums)
        {
            for (int i = 0; i < listNums.Count; i++)
            {
                listNums[i]--;
            }
        }
    }
}
