using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value of first rectangle side:");
            double.TryParse(Console.ReadLine(), out double FirstSide);
            Console.Write("Enter value of second rectangle side:");
            double.TryParse(Console.ReadLine(), out double SecondSide);
            Rectangle FirstRec = new Rectangle(FirstSide, SecondSide);
            Console.WriteLine("Area of Rectangle " + FirstRec.AreaCalculator());
            Console.WriteLine("Perimetr of Rectangle " + FirstRec.PerimeterCalculator());
            Console.ReadKey();
        }

    }
    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return (side2 + side1) * 2;
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
    }
}
