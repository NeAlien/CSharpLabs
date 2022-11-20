using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5Part2
{
    class Program
    {

        class MyList<T> : IEnumerable
        {
            public T[] newList = new T[5];
            int size = 5;
            int index = 0;
            public MyList(params T[] tmpList)
            {
                newList = new T[tmpList.Count()];
                size = tmpList.Count();
                foreach (T elem in tmpList)
                {
                    newList[index] = elem;
                    index++;
                }
            }

            public void Add(params T[] tmpList)
            {
                if (tmpList.Count() >= size - newList.Count())
                {
                    T[] temp = new T[newList.Count()];
                    for (int i = 0; i < index; i++)
                    {
                        temp[i] = newList[i];
                    }
                    newList = new T[tmpList.Count() + size];
                    size = tmpList.Count() + size;
                    for (int i = 0; i < index; i++)
                    {
                        newList[i] = temp[i];
                    }
                }
                foreach (T elem in tmpList)
                {
                    newList[index] = elem;
                    index++;
                }
            }

            public T this[int elem]
            {
                get
                {
                    return newList[elem];
                }
                set
                {
                    newList[elem] = value;
                }
            }

            public int Size
            {
                get
                {
                    Console.Write("MyList size: ");
                    return newList.Count();
                }
            }
            public void Print()
            {
                for (int i = 0; i < index; i++)
                {
                    Console.Write(newList[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            public IEnumerator GetEnumerator()
            {
                return newList.GetEnumerator();
            }


        }

        static void Main(string[] args)
        {


            MyList<int> list = new MyList<int>(8, 4, 3, 5, 12, 10, 7, 93);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Print();
            Console.WriteLine(list.Size);

            list.Add(10, 4, 5, 7, 6, 7, 3, 5, 9, 1, 2000, 190856);

            list.Print();
            Console.WriteLine(list.Size);

            list.Add(420);

            list.Print();
            Console.WriteLine(list.Size);

            Console.WriteLine(list[20]);
        }
    }
}
