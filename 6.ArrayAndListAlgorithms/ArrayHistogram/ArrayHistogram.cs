using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayHistogram
{
    public class ArrayHistogram
    {
        public static void Main()
        {
            string[] inputString = Console.ReadLine()
                .Split(' ');

            List<string> wordsList = new List<string>();
            List<int> occurencesCountList = new List<int>();

            for (int i = 0; i < inputString.Length; i++)
            {
                string currentWord = inputString[i];
                if (wordsList.Contains(currentWord))
                {
                    int wordIndex = wordsList.IndexOf(currentWord);
                    occurencesCountList[wordIndex]++;
                }

                else
                {
                    wordsList.Add(currentWord);
                    occurencesCountList.Add(1);
                }
            }

            bool swap = false;
            do
            {
                swap = false;

                for (int i = 0; i < occurencesCountList.Count - 1; i++)
                {
                    if (occurencesCountList[i] < occurencesCountList[i + 1])
                    {
                        swap = true;
                        int temp = occurencesCountList[i];
                        occurencesCountList[i] = occurencesCountList[i + 1];
                        occurencesCountList[i + 1] = temp;

                        string tempWord = wordsList[i];
                        wordsList[i] = wordsList[i + 1];
                        wordsList[i + 1] = tempWord;
                    }
                }

            } while (swap);

            for (int i = 0; i < wordsList.Count; i++)
            {
                double percentage = (occurencesCountList[i] / (double)inputString.Length) * 100;
                Console.WriteLine($"{wordsList[i]} -> {occurencesCountList[i]} times ({percentage:F2}%)");
            }
        }
    }
}