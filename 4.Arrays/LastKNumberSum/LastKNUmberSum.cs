namespace LastKNumberSum
{
    using System;

    public class LastKNUmberSum
    {
        public static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            int sequenceK = int.Parse(Console.ReadLine());

            long[] numArray = new long[numberN];
            numArray[0] = 1;
            for (int i = 1; i <numArray.Length ; i++)
            {
                numArray[i] = SumKElements(numArray,i-sequenceK, i-1);
            }

            Console.WriteLine(string.Join(" ", numArray));
        }

        public static long SumKElements(long[] arr,int startIndex, int endIndex)
        {
            long sum = 0;

            for (int i = startIndex; i <=endIndex; i++)
            {
                if(i>=0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
    }
}
