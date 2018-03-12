using System;
using System.Linq;

public class Rectangle
{
    public int Top { get; set; }
    public int Left { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Right
    {
        get
        {
            return Left + Width;
        }
    }

    public int Bottom
    {
        get
        {
            return Top + Height;
        }
    }
}


public class Program
{
    public static void Main()
    {
        Rectangle r1 = ReadRectangles(Console.ReadLine());
        Rectangle r2 = ReadRectangles(Console.ReadLine());

        bool isFirstInside = IsInside(r1, r2);
        bool isSecondInside = IsInside(r2, r1);

        if (isFirstInside)
        {
            Console.WriteLine("Inside");
        }

        else
        {
            Console.WriteLine("Not inside");
        }

    }

    public static bool IsInside(Rectangle r1, Rectangle r2)
    {
        if ((r1.Left >= r2.Left) && (r1.Right <= r2.Right) && (r1.Top >= r2.Top) && (r1.Bottom <= r2.Bottom))
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    private static Rectangle ReadRectangles(string input)
    {
        int[] tokens = input.Split(' ').Select(int.Parse).ToArray();
        Rectangle rectangle = new Rectangle
        {
            Left = tokens[0],
            Top = tokens[1],
            Width = tokens[2],
            Height = tokens[3]
        };

        return rectangle;
    }
}

