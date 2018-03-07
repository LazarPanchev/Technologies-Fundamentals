using System;
using System.IO;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("output.txt");
            var lines = File.ReadAllLines("input.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                int[] numbers = lines[i].Split(' ').Select(int.Parse).ToArray();

                int maxCounter = 0;
                int mostFrequentNum = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    int temporaryNum = numbers[j];
                    int counter = 0;

                    for (int k = j; k < numbers.Length; k++)
                    {
                        if (temporaryNum == numbers[k])
                        {
                            counter++;
                        }

                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            mostFrequentNum = temporaryNum;
                        }
                    }
                }

                File.AppendAllText("output.txt", mostFrequentNum.ToString()+Environment.NewLine);
            }
        }
    }
}
