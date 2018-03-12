using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine().Split(' ').Select(int.Parse).Where(x=> x>=0 && x<sizeOfField).ToArray();
            string commands = Console.ReadLine();
            int[] ladyBugsArray = new int[sizeOfField];
            
            for (int i = 0; i < initialIndexes.Length; i++)
            {
               // if(initialIndexes[i]>=0 && initialIndexes[i]<=ladyBugsArray.Length-1)
               // {
                    ladyBugsArray[initialIndexes[i]] = 1;

                //}
                
            }

            while (commands!= "end")
            {
                
                string[] tokens = commands.Split(' ').ToArray();

                int ladyBugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLenght = int.Parse(tokens[2]);

                if(InsProperIndex(ladyBugsArray,ladyBugIndex))
                {
                    MoveBugs(ladyBugsArray, ladyBugIndex,direction, flyLenght);
                }
                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladyBugsArray));
        }

        private static void MoveBugs(int[] ladyBugsArray, int ladyBugIndex, string direction, int flyLenght)
        {
            switch (direction)
            {
                case "right":
                    MoveRight(ladyBugsArray, ladyBugIndex, flyLenght);
                    break;
                case "left":
                    MoveLeft(ladyBugsArray, ladyBugIndex, flyLenght);
                    break;
            }

        }

        private static void MoveLeft(int[] ladyBugsArray, int ladyBugIndex, int flyLenght)
        {
            if(flyLenght<0)
            {
                flyLenght = Math.Abs(flyLenght);
                MoveRight(ladyBugsArray, ladyBugIndex, flyLenght);
            }

            else
            {
                ladyBugsArray[ladyBugIndex] = 0;
                bool bugFoundPlace = false;
                while (true)
                {
                    if (ladyBugIndex < 0 || bugFoundPlace)
                    {
                        break;
                    }

                    ladyBugIndex -= flyLenght;

                    if (ladyBugIndex >= 0)
                    {
                        if (ladyBugsArray[ladyBugIndex] == 0)
                        {
                            bugFoundPlace = true;
                            ladyBugsArray[ladyBugIndex]=1;
                        }
                    }
                }
            }
        }

        private static void MoveRight(int[] ladyBugsArray, int ladyBugIndex, int flyLenght)
        {
            ladyBugsArray[ladyBugIndex] = 0;
            bool bugFoundPlace = false;
            while (true)
            {
                if (ladyBugIndex>ladyBugsArray.Length-1 || bugFoundPlace)
                {
                    break;
                }

                ladyBugIndex += flyLenght;

                if (ladyBugIndex <= ladyBugsArray.Length - 1)
                {
                    if (ladyBugsArray[ladyBugIndex] == 0)
                    {
                        bugFoundPlace = true;
                        ladyBugsArray[ladyBugIndex] = 1;

                    }
                }
            }
        }

        private static bool InsProperIndex(int[] ladyBugsArray, int ladyBugIndex)
        {
            if(ladyBugIndex>=0 && ladyBugIndex<=ladyBugsArray.Length-1)
            {
                if(ladyBugsArray[ladyBugIndex]==1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
