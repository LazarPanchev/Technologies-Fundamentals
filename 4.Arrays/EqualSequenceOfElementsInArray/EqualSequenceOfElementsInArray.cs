namespace EqualSequenceOfElementsInArray
{
    using System;
    using System.Linq;

    public class EqualSequenceOfElementsInArray
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool IsTheSame = true;
            for (int i = 0; i < array.Length-1; i++)
            {
                int currentNum = array[i];
                if(currentNum!=array[i+1])
                {
                    IsTheSame = false;
                    break;
                }
            }

            if(IsTheSame)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
