namespace CountOfNegativeElementsInArray
{
    using System;
    using System.Linq;

    public class CountOfNegativeElementsInArray
    {
        public static void Main()
        {
            int nLines = int.Parse(Console.ReadLine());
            int[] arrayOfIntegers = new int[nLines];
            int counter = 0;

            for (int i = 0; i < nLines; i++)
            {
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
                if(arrayOfIntegers[i]<0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
