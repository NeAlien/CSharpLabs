using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3Part2
{
    class Program
    {
        public class Car : IEquatable<Car>
        {
            public string Name;
            public string Engine;
            public int MaxSpeed;
            
            public Car (string name1, string engine1, int speed1)
            {
                Name = name1;
                Engine = engine1;
                MaxSpeed = speed1;
            }

            public bool Equals(Car car)
            {
                return (this.Name, this.Engine, this.MaxSpeed) == (car.Name, car.Engine, car.MaxSpeed);
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public class CarsCatalog
        {
            Car[] carsCollection;

            public CarsCatalog(params Car[] car1)
            {
                carsCollection = car1;
            }

            public string this[int index]
            {
                get
                {
                    return $"{carsCollection[index].Name} | {carsCollection[index].Engine}";
                }
            }
        }

        static void Main(string[] args)
        {
            Car Car1 = new Car("Car1", "Engine1", 150);
            Car Car2 = new Car("Car2", "Engine2", 200);
            Car Car3 = new Car("Car3", "Engine3", 250);

            CarsCatalog myCars = new CarsCatalog(Car1, Car2, Car3);

            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(myCars[i] + "\n");
            }

            string carName = Car1.ToString();

            Console.WriteLine("Car from ToString(): " + carName + "\n");

            Console.WriteLine("Equality of Car1 and Car2: " + Equals(Car1, Car3) + "\n");
            Console.WriteLine("Equality of Car2 and Car2: " + Equals(Car2, Car2) + "\n");
        }
    }
}
