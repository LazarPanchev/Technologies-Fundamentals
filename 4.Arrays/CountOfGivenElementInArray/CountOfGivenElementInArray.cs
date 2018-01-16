namespace CountOfGivenElementInArray
{
    using System;
    using System.Linq;

    public class CountOfGivenElementInArray
    {
        public static void Main()
        {
            int[] numbersArray = (Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            int numberForCheck = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if(numbersArray[i]==numberForCheck)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
