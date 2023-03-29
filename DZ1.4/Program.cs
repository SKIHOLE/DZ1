using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 3, "B");
            Point C = new Point(4, 0, "C");
            Figure triangle = new Figure(A, B, C);
            triangle.PerimeterCalculator();
            Console.ReadKey();
        }
        class Point
        {
            private int x;
            private int y;
            private string name;

            public Point(int x, int y, string name)
            {
                this.x = x;
                this.y = y;
                this.name = name;
            }

            public int X { get { return x; } }
            public int Y { get { return y; } }
            public string Name { get { return name; } }


        }
        class Figure
        {
            private Point[] points;
            public Figure(Point p1, Point p2, Point p3)
            {
                points = new Point[3] { p1, p2, p3 };
            }
            public Figure(Point p1, Point p2, Point p3, Point p4)
            {
                points = new Point[4] { p1, p2, p3, p4 };
            }
            public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
            {
                points = new Point[5] { p1, p2, p3, p4, p5 };
            }
            public double LengthSide(Point A, Point B)
            {
                double length = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
                return length;
            }
            public void PerimeterCalculator()
            {
                double perimeter = 0;
                for (int i = 0; i < points.Length; i++)
                {
                    Point A = points[i];
                    Point B = (i == points.Length - 1) ? points[0] : points[i + 1];
                    perimeter += LengthSide(A, B);

                }

                Console.WriteLine($"Назва багатокутника: {points[0].Name}");
                Console.WriteLine($"Периметр багатокутника: {perimeter}");
            }
        }
    }
}
