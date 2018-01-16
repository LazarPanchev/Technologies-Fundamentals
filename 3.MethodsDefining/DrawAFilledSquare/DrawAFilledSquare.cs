namespace DrawAFilledSquare
{
    using System;
    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());
            PrintHeaderFooter(inputNum);
            for (int i = 0; i < inputNum-2; i++)
            {
                PrintMiddlePart(inputNum);
            }
            PrintHeaderFooter(inputNum);
        }
        public static void PrintHeaderFooter(int number)
        {
            Console.WriteLine(new string('-',number*2));
        }
        public static void PrintMiddlePart(int number)
        {
            Console.Write("-");
            for (int i =1; i <number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
