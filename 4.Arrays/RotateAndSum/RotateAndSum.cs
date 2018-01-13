namespace RotateAndSum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotateTimesK = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotateTimesK; i++)
            {
                int[] rotateArray= RotateArray(array);
                SumArrays(array,rotateArray);
            }

            Console.WriteLine(String.Join(" ",SumArrays));
        }

        private static int[] SumArrays(int[] array, int[] rotatearray)
        {
            int[] sumArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                sumArray[i] = array[i] + rotatearray[i];
            }

            return sumArray;

        }
        
        public static int[] RotateArray(int[] array)
        {
            int[] rotateArray = new int[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                rotateArray[i + 1] = array[i];
            }

            var lastElement = array[array.Length - 1];
            rotateArray[0] = lastElement;

            return rotateArray;
        }
    }
}
