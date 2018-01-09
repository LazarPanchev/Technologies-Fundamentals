namespace CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter=Console.ReadLine();
            double cubeProperties = CubeCalculationParameter(cubeSide, parameter);
            Console.WriteLine("{0:F2}",cubeProperties);
        }

        public static double CubeCalculationParameter(double cubeSide, string parameter)
        {
            double result = 0;
            if(parameter=="face")
            {
                result = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            }
            else if(parameter=="space")
            {
                result = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            }
            else if (parameter == "volume")
            {
                result = Math.Pow(cubeSide, 3);
            }
            else if (parameter == "area")
            {
                result = 6* Math.Pow(cubeSide, 2);
            }
            return result;
        }
    }
}
