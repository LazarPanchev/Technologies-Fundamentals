namespace CalculateTriangleArea
{
    using System;
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double triangleSideA = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(triangleSideA, triangleHeight);
            Console.WriteLine(area);
        }
        public static double GetTriangleArea(double width,double height)
        {
            return (width * height)/2;
        }
    }
}
