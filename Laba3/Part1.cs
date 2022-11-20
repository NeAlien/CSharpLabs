using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class Program
    {
        public struct Vector
        {
            double X;
            double Y;
            double Z;
            public Vector(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            private double lenght()
            {
                return (Math.Sqrt(Math.Pow(X - 0, 2) + Math.Pow(Y - 0, 2) + Math.Pow(Z - 0, 2)));
            }

            public void print()
            {
                Console.WriteLine($"X - {X}");
                Console.WriteLine($"Y - {Y}");
                Console.WriteLine($"Z - {Z}");
                Console.WriteLine("\n");
            }

            public static Vector operator +(Vector vec1, Vector vec2)
            {
                Vector resultVec = new Vector(vec1.X + vec2.X, vec1.Y + vec2.Y, vec1.Z + vec2.Z);
                return resultVec;
            }

            public static Vector operator *(Vector vec1, double a)
            {
                double x1 = vec1.X * a;
                double y1 = vec1.Y * a;
                double z1 = vec1.Z * a;
                return new Vector(x1, y1, z1);
            }

            public static Vector operator *(Vector vec1, Vector vec2)
            {
                Vector newVec = new Vector(vec1.X * vec2.X, vec1.Y * vec2.Y, vec1.Z * vec2.Z);
                return newVec;
            }

            public static bool operator >(Vector vec1, Vector vec2)
            {
                if (vec1.lenght() > vec2.lenght())
                {
                    return true;
                }
                return false;
            }

            public static bool operator <(Vector vec1, Vector vec2)
            {
                if (vec1.lenght() > vec2.lenght())
                {
                    return true;
                }
                return false;
            }

            public static bool operator <=(Vector vec1, Vector vec2)
            {
                if (vec1.lenght() <= vec2.lenght())
                {
                    return true;
                }
                return false;
            }

            public static bool operator >=(Vector vec1, Vector vec2)
            {
                if (vec1.lenght() >= vec2.lenght())
                {
                    return true;
                }
                return false;
            }

            public static bool operator ==(Vector vec1, Vector vec2)
            {
                if (vec1.lenght() == vec2.lenght())
                {
                    return true;
                }
                return false;
            }

            public static bool operator !=(Vector vec1, Vector vec2)
            {
                if (vec1.lenght() != vec2.lenght())
                {
                    return true;
                }
                return false;
            }
        }

            static void Main(string[] args)
        {
            Vector vecNew;
            Vector vecOne = new Vector(1, 1, 1);
            Vector vecTwo = new Vector(3, 2, 5);

            vecNew = vecOne * 5;
            vecNew.print();

            vecNew = vecOne * vecTwo;
            vecNew.print();

            vecNew = vecOne + vecTwo;
            vecNew.print();

            vecOne = vecOne * vecTwo;
            Console.WriteLine(vecOne == vecTwo);
        }
    }
}
