using System;
using System.Linq;
using System.Collections.Generic;


namespace PokemonDon_tGo
{
    public class Program
    {
        public static void Main()
        {
            List<int> sequenceList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> removedNums = new List<int>();

            int currentRemoved = 0;
            while (sequenceList.Count>0)
            {
                int currentIndex = int.Parse(Console.ReadLine());

                if(currentIndex>=0 && currentIndex<=sequenceList.Count-1)
                {
                    currentRemoved = sequenceList[currentIndex];
                    removedNums.Add(currentRemoved);
                    sequenceList.RemoveAt(currentIndex);
                    IncreaseSequence(sequenceList, currentRemoved);
                }

                else
                {
                    if(currentIndex<0)
                    {
                        currentRemoved = sequenceList[0];
                        removedNums.Add(currentRemoved);
                        sequenceList.RemoveAt(0);
                        sequenceList.Insert(0, sequenceList[sequenceList.Count - 1]);
                        IncreaseSequence(sequenceList, currentRemoved);
                    }
                    else
                    {
                        currentRemoved = sequenceList[sequenceList.Count - 1];
                        removedNums.Add(currentRemoved);
                        sequenceList.RemoveAt(sequenceList.Count - 1);
                        sequenceList.Add(sequenceList[0]);
                        IncreaseSequence(sequenceList, currentRemoved);
                    }
                }
            }

            Console.WriteLine(removedNums.Sum());
        }

        private static void IncreaseSequence(List<int> sequenceList, int currentRemoved)
        {
            for (int i = 0; i < sequenceList.Count; i++)
            {
                if(sequenceList[i]<=currentRemoved)
                {
                    sequenceList[i] += currentRemoved;
                }

                else
                {
                    sequenceList[i] -= currentRemoved;
                }
            }
        }
    }
}
