

namespace RectangleProperties
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double rectWidth = double.Parse(Console.ReadLine());
            double rectHeight = double.Parse(Console.ReadLine());
            double rectPerimeter = (rectWidth + rectHeight) * 2;
            double rectArea = rectHeight * rectWidth;
            double rectDiagonal = Math.Sqrt(((rectWidth) * (rectWidth) + (rectHeight) * (rectHeight)));
            Console.WriteLine(rectPerimeter);
            Console.WriteLine(rectArea);
            Console.WriteLine(rectDiagonal);


        }
    }
}
