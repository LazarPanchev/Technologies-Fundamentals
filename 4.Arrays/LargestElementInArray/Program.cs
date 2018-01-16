namespace LargestElementInArray
{
    using System;

    public class Program
    {
        //https://judge.softuni.bg/Contests/Practice/Index/418#9
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int largestNumber = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if(array[i]>largestNumber)
                {
                    largestNumber = array[i];
                }
            }

            Console.WriteLine(largestNumber);
        }
    }
}
