namespace GeometryCalculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            string geometryFigure = Console.ReadLine();
            double areaFigure = 0;

            if(geometryFigure=="triangle" || geometryFigure=="rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                areaFigure = CalculateArea(width, height,geometryFigure);
            }

            else if(geometryFigure=="square" || geometryFigure=="circle")
            {
                double figureParameter = double.Parse(Console.ReadLine());
                areaFigure = CalculateArea(figureParameter,geometryFigure);
            }

            Console.WriteLine("{0:F2}",areaFigure);
        }

        public static double CalculateArea(double parameter, string figure)
        {
            double area = 0;

            if(figure=="square")
            {
                area = parameter * parameter;
            }

            else if(figure=="circle")
            {
                area = Math.PI * Math.Pow(parameter, 2);
            }

            return area;    
        }

        public static double CalculateArea(double width,double height,string figure)
        {
            double area = 0;
            if (figure == "triangle")
            {
                area = (width * height) / 2;
            }

            else if (figure == "rectangle")
            {
                area = width * height;
            }

            return area;
        }
    }
}
