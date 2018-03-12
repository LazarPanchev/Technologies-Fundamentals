using System;
using System.Linq;

    class IntersectionOfCircles
    {
        public static void Main()
        {
            var firstCircleInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var secondCircleInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Point firsCenter = new Point(firstCircleInput[0], firstCircleInput[1]);
            Point secondCenter = new Point(secondCircleInput[0], secondCircleInput[1]);

            Circle firstCircle = new Circle(firsCenter, firstCircleInput[2]);
            Circle secondCircle = new Circle(secondCenter, secondCircleInput[2]);

            if(Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }

