namespace ArraySymmetry
{
    using System;
    using System.Linq;

    public class ArraySymmetry
    {
        public static void Main()
        {
            string[] arrayString = Console.ReadLine().Split(' ').ToArray();
            bool IsSymmetric = true;

            for (int i = 0; i <arrayString.Length/2; i++)
            {
                string currentWord = arrayString[i];
                if (currentWord != arrayString[arrayString.Length - 1 - i])
                {
                    IsSymmetric = false;
                }
            }

            if(IsSymmetric)
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
