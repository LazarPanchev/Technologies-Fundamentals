
public class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }

    public Circle(Point center, int radius)
    {
        Center = center;
        Radius = radius;
    }

    public static bool Intersect(Circle c1, Circle c2)
    {
        int d = Point.CalculateDistnace(c1.Center, c2.Center);

        if (d <= c1.Radius + c2.Radius)
        {
            return true;
        }

        return false;
    }

}

