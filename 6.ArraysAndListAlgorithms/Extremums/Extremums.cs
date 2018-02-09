using System;
using System.Linq;
using System.Collections.Generic;

namespace Extremums
{
    public class Program
    {
        public static void Main()
        {
            string[] inputNumbers = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string command = Console.ReadLine();
            int sum = 0;
            int[] result = new int[inputNumbers.Length];

            if(command=="Min")
            {
                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    int minNumPossible = int.MaxValue;
                    int endIndex = inputNumbers[i].Length;
                    string num = inputNumbers[i];
                    for (int j = 0; j < endIndex; j++)
                    {
                        char[] numberAfterOneRotation = NumberRotation(num);
                        num = new string(numberAfterOneRotation);
                        int currentNumber = int.Parse(num);
                        if (currentNumber < minNumPossible)
                        {
                            minNumPossible = currentNumber;
                        }
                    }

                    sum += minNumPossible;
                    result[i] = minNumPossible;
                }
            }

            else if(command=="Max")
            {
                
                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    int maxNumPossible = int.MinValue;
                    int endIndex = inputNumbers[i].Length;
                    string num = inputNumbers[i];
                    for (int j = 0; j < endIndex; j++)
                    {
                        char[] numberAfterOneRotation = NumberRotation(num);
                        num = new string(numberAfterOneRotation);
                        int currentNumber = int.Parse(num);
                        if (currentNumber > maxNumPossible)
                        {
                            maxNumPossible = currentNumber;
                        }
                    }

                    sum += maxNumPossible;
                    result[i] = maxNumPossible;
                }
            }

            Console.WriteLine(string.Join(", ",result));
            Console.WriteLine(sum);
        }

        private static char[] NumberRotation(string inputNumbers)
        {           
            char[] currentNum = inputNumbers.ToCharArray();
            char lastDigit = currentNum[currentNum.Length - 1];
            for (int i = currentNum.Length - 1; i > 0 ; i--)
            {
                currentNum[i] = currentNum[i - 1];
            }

            currentNum[0] = lastDigit;          
            return currentNum;
        }
    }
}
