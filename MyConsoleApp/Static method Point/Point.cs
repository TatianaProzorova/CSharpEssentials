using System;

namespace MyConsoleApp
{
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double LengthPoints(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));
        }

        // code in Main()
        //Point point1 = new Point(1, 5);
        //Point point2 = new Point(5, 5);
        //Console.WriteLine(Point.LengthPoints(point1, point2)); // 4
    }
}



