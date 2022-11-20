using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Laba2Part2
{
    class Program
    {
        public class Vehicle
        {
            private int price;
            private int speed;
            private int year;

            public Vehicle()
            {
                price = 0;
                speed = 0;
                year = 0;
            }
            public Vehicle (int nPrice, int nSpeed, int nYear )
            {
                price = nPrice;
                speed = nSpeed;
                year = nYear;
            }
            public virtual void Print()
            {
                Console.WriteLine($"Price: {this.price}");
                Console.WriteLine($"Speed: {this.speed}");
                Console.WriteLine($"Year: {this.year}");
            }
        }
        class Car : Vehicle
        {
            public Car(int nPrice, int nSpeed, int nYear) : base(nPrice, nSpeed, nYear) { }
            public override void Print()
            {
                Console.WriteLine("CAR: ");
                base.Print();
            }
        }
        class Plane : Vehicle
        {
            private int hight;
            private int passangers;
            public Plane(int nPrice, int nSpeed, int nYear, int nHight, int nPassangers) : base(nPrice, nSpeed, nYear)
            {
                hight = nHight;
                passangers = nPassangers;
            }
            public override void Print()
            {
                Console.WriteLine("PLANE: ");
                base.Print();
                Console.WriteLine($"Hight: {this.hight}");
                Console.WriteLine($"Passangers: {this.passangers}");
            }
        }

        class Ship : Vehicle
        {
            private int port;
            private int passangers;
            public Ship(int nPrice, int nSpeed, int nYear, int nPort, int nPassangers) : base(nPrice, nSpeed, nYear)
            {
                port = nPort;
                passangers = nPassangers;
            }
            public override void Print()
            {
                Console.WriteLine("SHIP: ");
                base.Print();
                Console.WriteLine($"Port: {this.port}");
                Console.WriteLine($"Passangers: {this.passangers}");
            }
        }

        static void Main(string[] args)
        {
            Car ob1 = new Car(20000, 220, 2020);
            Plane ob2 = new Plane(3400000, 500, 2010, 3500, 4);
            Ship ob3 = new Ship(89000, 160, 2005, 5, 5);
            ob1.Print();
            Console.WriteLine("\n\n");
            ob2.Print();
            Console.WriteLine("\n\n");
            ob3.Print();
        }
    }
}
