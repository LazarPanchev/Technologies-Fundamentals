namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = 1;
            int maxLenght = 0;
            int sequence = 0;

            for (int i = 0; i <numbers.Length-1; i++)
            {
                if(numbers[i]==numbers[i+1])
                {
                    length++;
                    
                }

                else
                {
                    length = 1;
                }

                if(length>maxLenght)
                {
                    sequence = numbers[i];
                    maxLenght = length;
                }
            }
            int[] newArray = new int[maxLenght];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = sequence;
            }

            Console.WriteLine(String.Join(" ",newArray));
        }
    }
}
