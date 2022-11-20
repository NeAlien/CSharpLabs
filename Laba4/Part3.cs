using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4Part3
{
    class Program
    {
        class Car
        {
            public string Name { get; set; }
            public int ProductionYear { get; set; }
            public int MaxSpeed { get; set; }

            public Car(string name, int year, int speed)
            {
                Name = name;
                ProductionYear = year;
                MaxSpeed = speed;
            }
            public void print()
            {
                Console.WriteLine($"Name: {Name} ");
                Console.WriteLine($"Year: {ProductionYear} ");
                Console.WriteLine($"Speed: {MaxSpeed} ");
                Console.WriteLine("\n");
            }
        }

        public enum CarComparerType
        {
            ProductionYear,
            MaxSpeed
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

        class CarCatalog
        {
            public List<Car> collection = new List<Car>();
            public CarCatalog(params Car[] cars)
            {
                for (int i = 0; i < cars.Length; ++i)
                {
                    collection.Add(cars[i]);
                }
            }
            public IEnumerator<Car> GetEnumerator()
            {
                for (int i = 0; i < collection.Count; ++i)
                {
                    yield return collection[i];
                }
            }

            public IEnumerable<Car> Reverse()
            {
                for (int i = collection.Count - 1; i >= 0; --i)
                {
                    yield return collection[i];
                }
            }

            public IEnumerable<Car> YearProduct(int y)
            {

                for (int i = 0; i < collection.Count; ++i)
                {
                    if (collection[i].ProductionYear == y)
                    yield return collection[i];
                }
            }

            public IEnumerable<Car> Speed(int s)
            {
                for (int i = 0; i < collection.Count; ++i)
                {
                    if (collection[i].MaxSpeed == s)
                    yield return collection[i];
                }
            }
        }

        static void Main(string[] args)
        {
            Car car1 = new Car("Car5", 2015, 190);
            Car car2 = new Car("Car6", 2013, 210);
            Car car3 = new Car("Car7", 2020, 150);
            Car car4 = new Car("Car8", 2021, 130);

            CarCatalog catalog = new CarCatalog(car1, car2, car3, car4);

            foreach (Car elem in catalog)
            {
                elem.print();
            }
            Console.WriteLine("***************");

            foreach (Car elem in catalog.Reverse())
            {
                elem.print();
            }
            Console.WriteLine("***************");


            Console.WriteLine("Year: ");
            foreach (Car elem in catalog.YearProduct(2013))
            {
                elem.print();
            }
            Console.WriteLine("***************");

            Console.WriteLine("Speed: ");
            foreach (Car elem in catalog.Speed(130))
            {
                elem.print();
            }
            Console.WriteLine("***************");
        }
    }
}
