namespace MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sequence = 0;
            int endIndex = 0;
            int maxSequence = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if(numbers[i]< numbers[i+1])
                {
                    sequence++;
                    
                }

                else
                {
                    sequence = 0;
                }

                if(sequence>maxSequence)
                {
                    maxSequence = sequence;
                    endIndex = i+1;
                }
            }

            int startIndex =endIndex-maxSequence;
            for (int i = 0; i <=maxSequence; i++)
            {
                Console.Write(numbers[startIndex] + " ");
                startIndex++; 
            }
        }
    }
}
