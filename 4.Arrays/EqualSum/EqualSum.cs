namespace EqualSum
{
    using System;
    using System.Linq;

    public class EqualSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int middleindex = 0;
            bool findMiddleDigit = false;
            for (int i = 0; i < numbers.Length; i++)
            {

                int currentIndex = i;
                int leftSum = SumLeftPart(numbers, currentIndex);
                int rightSum = SumRightPart(numbers, currentIndex);
                if (leftSum == rightSum)
                {
                    middleindex = currentIndex;
                    findMiddleDigit = true;
                }
            }

            if(findMiddleDigit)
            {
                Console.WriteLine(middleindex);
            }

            else
            {
                Console.WriteLine("no");
            }
           

        }

        public static int SumLeftPart(int[] numbers, int currentIndex)
        {
            int sum = 0;
            for (int i = 0; i < currentIndex; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static int SumRightPart(int[] numbers, int currentIndex)
        {
            int sum = 0;
            for (int i = currentIndex+1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        
    }
}
