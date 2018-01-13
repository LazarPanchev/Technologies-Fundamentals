namespace LongerLine
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            double firstPointX1 = double.Parse(Console.ReadLine());
            double firstPointY1 = double.Parse(Console.ReadLine());
            double secondPointX2 = double.Parse(Console.ReadLine());
            double secondPointY2 = double.Parse(Console.ReadLine());
            double thirdPointX3 = double.Parse(Console.ReadLine());
            double thirdPointY3 = double.Parse(Console.ReadLine());
            double fourthPointX4 = double.Parse(Console.ReadLine());
            double fourthPointY4 = double.Parse(Console.ReadLine());
            double firstSegment = SegmentDistance(firstPointX1, firstPointY1, secondPointX2, secondPointY2);
            double secondSegment= SegmentDistance(thirdPointX3, thirdPointY3, fourthPointX4, fourthPointY4);
            if(firstSegment>=secondSegment)
            {
                PrintLongerLine(firstPointX1, firstPointY1, secondPointX2, secondPointY2);
            }
            else
            {
                PrintLongerLine(thirdPointX3,thirdPointY3,fourthPointX4,fourthPointY4);
            }        
        }

        public static double SegmentDistance(double x1, double y1, double x2, double y2)
        {
            double segmentDistance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return segmentDistance;
        }
        
        public static void PrintLongerLine(double x1, double y1, double x2, double y2)
        {
            
            double firstPointsDistance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPointsDistance = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (firstPointsDistance <= secondPointsDistance)
            {

                Console.WriteLine("({0}, {1})({2}, {3})", x1,y1,x2,y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }

        }
    }
}
