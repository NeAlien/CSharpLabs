using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4Part2
{
    class Program
    {
        class Car
        {
            public string Name { get; set; }
            public int ProductionYear { get; set; }
            public int MaxSpeed { get; set; }

            public Car(string _name, int _year, int _speed)
            {
                Name = _name;
                ProductionYear = _year;
                MaxSpeed = _speed;
            }
            public void print()
            {
                Console.WriteLine($"Name: { Name} ");
                Console.WriteLine($"Year: {ProductionYear} ");
                Console.WriteLine($"Speed: { MaxSpeed} ");
                Console.WriteLine("\n");
            }
        }

        public enum CarComparerType
        {
            ProductionYear,
            MaxSpeed,
            Name
        }

        class CarComparer : IComparer<Car>
        {
            private CarComparerType _carComparerType;
            public CarComparer(CarComparerType comparerType)
            {
                _carComparerType = comparerType;
            }
            public int Compare(Car car1, Car car2)
            {
                if (_carComparerType == CarComparerType.Name)
                {
                    if (car1.Name.CompareTo(car2.Name) != 0)
                    {
                        return car1.Name.CompareTo(car2.Name);
                    }
                    return 0;
                }

                if (_carComparerType == CarComparerType.ProductionYear)
                {
                    if (car1.ProductionYear.CompareTo(car2.ProductionYear) != 0)
                    {
                        return car1.ProductionYear.CompareTo(car2.ProductionYear);
                    }
                    return 0;
                }

                if (_carComparerType == CarComparerType.MaxSpeed)
                {
                    if (car1.MaxSpeed.CompareTo(car2.MaxSpeed) != 0)
                    {
                        return car1.MaxSpeed.CompareTo(car2.MaxSpeed);
                    }
                    return 0;
                }
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Car car1 = new Car("Car1", 2015, 190);
            Car car2 = new Car("Car2", 2013, 210);
            Car car3 = new Car("Car3", 2020, 150);
            Car car4 = new Car("Car4", 2021, 130);

            List<Car> Collection = new List<Car> { car1, car2, car3, car4 };

            Collection.Sort(new CarComparer(CarComparerType.Name));

            Console.WriteLine("Sorting by name\n");
            for (int i = 0; i < Collection.Count; i++)
            {
                Collection[i].print();
            }
            Console.WriteLine("***************");

            Console.WriteLine("Sorting by production year\n");
            Collection.Sort(new CarComparer(CarComparerType.ProductionYear));
            for (int i = 0; i < Collection.Count; i++)
            {
                Collection[i].print();
            }
            Console.WriteLine("***************");

            Console.WriteLine("Sorting by max speed\n");
            Collection.Sort(new CarComparer(CarComparerType.MaxSpeed));
            for (int i = 0; i < Collection.Count; i++)
            {
                Collection[i].print();
            }
            Console.WriteLine("***************");
        }
    }
}
