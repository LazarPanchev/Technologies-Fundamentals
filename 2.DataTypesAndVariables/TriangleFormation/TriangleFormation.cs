
namespace TriangleFormation
{
    using System;
    public class TriangleFormation
    {
        public static void Main()
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());
            bool validTriangle = false;
            string rightTriangle = string.Empty;
            if((sideA+sideB>sideC) && (sideA+sideC>sideB) && (sideB+sideC>sideA))
            {
                validTriangle = true;
            }
            if(validTriangle)
            {
                if(Math.Pow(sideA,2)+Math.Pow(sideB,2)==Math.Pow(sideC,2))
                {
                    rightTriangle = "a right angle between sides a and b";
                }
                else if(Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2))
                {
                    rightTriangle = "a right angle between sides a and c";
                }
                else if(Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2))
                {
                    rightTriangle = "a right angle between sides b and c";
                }
                else
                {
                    rightTriangle = "no right angles";
                }
            }
            if(validTriangle)
            {
                Console.WriteLine("Triangle is valid.");
                Console.WriteLine("Triangle has " + rightTriangle);
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
