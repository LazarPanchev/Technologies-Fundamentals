using System;


namespace GameOfNumbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M= int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            string combinashion = string.Empty;
            bool hasCombinashion = false;
            int counter = 0;
            for (int i =N; i <=M; i++)
            {
                for (int j = N; j <=M; j++)
                {
                    counter++;
                    sum = i + j;
                    if(sum==magicalNumber)
                    {
                        combinashion = string.Format("{0} + {1} = {2}", i, j, sum);//$"{i} + {j} = {sum}";
                        hasCombinashion = true;

                    }
                }
            }
            if(hasCombinashion)
            {
                Console.WriteLine("Number found! "+combinashion);
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }
        }
    }
}
