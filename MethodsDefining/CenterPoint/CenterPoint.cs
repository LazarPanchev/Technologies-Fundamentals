namespace CenterPoint
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            double firstPointX1 = double.Parse(Console.ReadLine());
            double firstPointY1 = double.Parse(Console.ReadLine());
            double secondPointX2 = double.Parse(Console.ReadLine());
            double secondPointY2 = double.Parse(Console.ReadLine());
            CalculateClosesPoint(firstPointX1, firstPointY1, secondPointX2, secondPointY2);
        }

        public static void CalculateClosesPoint(double X1, double Y1, double X2, double Y2)
        {
            double firstPointsDistance= Math.Sqrt(Math.Pow(X1,2) + Math.Pow(Y1,2));
            double secondPointsDistance = Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
            if (firstPointsDistance <= secondPointsDistance)
            {

                Console.WriteLine("({0}, {1})", X1, Y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", X2, Y2);
            }

        }
    }
}
