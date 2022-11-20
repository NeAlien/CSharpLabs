using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Part2
{
    public class Rectangle
    {
        public double side1;
        public double side2;

        public Rectangle()
        {
            side1 = 0;
            side2 = 0;
        }

        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * side1 + 2 * side2;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double firstside;
            double secondside;
            string input1;
            string input2;

            Console.WriteLine("Enter size of first side: ");
            input1 = Console.ReadLine();
            firstside = double.Parse(input1);

            Console.WriteLine("Enter size of second side: ");
            input2 = Console.ReadLine();
            secondside = double.Parse(input2);

            Rectangle rec = new Rectangle(firstside, secondside);

            Console.WriteLine("Area of rectangle: {0}", rec.Area);
            Console.WriteLine("Perimetr of rectangle: {0}", rec.Perimeter);

        }
    }
}
