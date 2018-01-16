namespace RotateArrayOfString
{
    using System;
    using System.Linq;

    public class RotateArrayOfString
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();

            string[] rotateArray = new string[array.Length];

            for (int i = 0; i < array.Length-1; i++)
            {
                rotateArray[i + 1] = array[i];
            }

            var lastElement = array[array.Length - 1];
            rotateArray[0] = lastElement;
            Console.WriteLine(String.Join(" ", rotateArray));
        }
    }
}
