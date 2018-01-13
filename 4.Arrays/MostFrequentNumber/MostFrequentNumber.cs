namespace MostFrequentNumber
{
    using System;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxCounter = 0;
            int mostFrequentNum = 0;

            for (int i = 0; i <numbers.Length; i++)
            {
                int temporaryNum = numbers[i];
                int counter = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if(temporaryNum==numbers[j])
                    {
                        counter++;
                    }

                    if(counter>maxCounter)
                    {
                        maxCounter = counter;
                        mostFrequentNum = temporaryNum;
                    }
                }
            }

            Console.WriteLine(mostFrequentNum);
        }
    }
}
