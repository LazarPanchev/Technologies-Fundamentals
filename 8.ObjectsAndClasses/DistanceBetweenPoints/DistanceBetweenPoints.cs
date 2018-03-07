using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;
namespace Mentor_Group
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int nLines = int.Parse(Console.ReadLine());
            Point[] points = new Point[nLines];
            for (int i = 0; i < nLines; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Point point = new Point
                {
                    X = input[0],
                    Y = input[1]
                };

                points[i] = point;
            }

            Point[] result = new Point[2];
            FindClosestPoints(points, result);

            Console.WriteLine("({0}, {1})", result[0].X, result[0].Y);
            Console.WriteLine("({0}, {1})", result[1].X, result[1].Y);

        }

        public static void FindClosestPoints(Point[] points, Point[] result)
        {
            double minDistance = double.MaxValue;
            double currentDistance = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                Point currentPoint = points[i];
                for (int j = i + 1; j < points.Length; j++)
                {
                    Point nextPoint = points[j];
                    currentDistance = GetDistance(currentPoint, nextPoint);
                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        result[0] = currentPoint;
                        result[1] = nextPoint;
                    }
                }
            }
            Console.WriteLine("{0:F3}", minDistance);
        }

        public static double GetDistance(Point p1, Point p2)
        {
            double firstPart = (p1.X - p2.X) * (p1.X - p2.X);
            double secondPart = (p1.Y - p2.Y) * (p1.Y - p2.Y);
            return Math.Sqrt(firstPart + secondPart);
        }
    }
}