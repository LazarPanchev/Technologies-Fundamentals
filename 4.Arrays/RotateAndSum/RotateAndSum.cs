namespace RotateAndSum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rotate = int.Parse(Console.ReadLine());
            int[] sum = new int[inputArray.Length];

            for (int i = 0; i < rotate; i++)
            {
                RotateArr(inputArray);
                SumArrays(inputArray, sum);
            }

            Console.WriteLine(String.Join(" ",sum));
        }

        public static void RotateArr(int[] array)
        {

            int firstDigit = array[array.Length - 1];
            for (int i = array.Length-1; i >0; i--)
            {
                array[i] = array[i-1];
            }

            array[0] = firstDigit;    
        }

        public static void SumArrays(int[] inputArray,int[] sum)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                sum[i] += inputArray[i];
            }
        }
    }
}
