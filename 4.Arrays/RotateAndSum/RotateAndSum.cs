namespace RotateAndSum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
<<<<<<< HEAD
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
=======
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
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852
        }
    }
}
