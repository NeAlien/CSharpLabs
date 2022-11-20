using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2Part1
{
    class Program
    {
        public class ClassRoom
        {
            private Pupil[] pupils = new Pupil[4];

            public ClassRoom(params Pupil[] SchoolClass)
            {
                for (int i = 0; i < SchoolClass.Length; ++i)
                {
                    if (SchoolClass[i] != null)
                    {
                        pupils[i] = SchoolClass[i];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            public void PrintClassInfo()
            {
                for (int i = 0; i < pupils.Length; ++i)
                {
                    if (pupils[i] != null)
                    {
                        Console.WriteLine($"Pupil #{i + 1}");
                        pupils[i].Study();
                        pupils[i].Write();
                        pupils[i].Read();
                        pupils[i].Relax();
                    }
                    else
                    {
                        break;
                    }
                    Console.WriteLine("\n\n");
                }
                Console.WriteLine("######################################");
            }
        }

        public class Pupil
        {
            public virtual void Study() { }
            public virtual void Read() { }
            public virtual void Write() { }
            public virtual void Relax() { }
        }

        public class ExcelentPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("This pupil can study exelent");
            }

            public override void Read()
            {
                Console.WriteLine("This pupil can read excelent");
            }

            public override void Write()
            {
                Console.WriteLine("This pupil can write excelent");
            }

            public override void Relax()
            {
                Console.WriteLine("This pupil can relax excelent");
            }
        }

        public class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("This pupil can study well");
            }

            public override void Read()
            {
                Console.WriteLine("This pupil can read well");
            }

            public override void Write()
            {
                Console.WriteLine("This pupil can write well");
            }

            public override void Relax()
            {
                Console.WriteLine("This pupil can relax well");
            }
        }

        public class BadPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("This pupil can't study");
            }

            public override void Read()
            {
                Console.WriteLine("This pupil can't read");
            }

            public override void Write()
            {
                Console.WriteLine("This pupil can't write");
            }

            public override void Relax()
            {
                Console.WriteLine("This pupil can't chill");
            }
        }

        static void Main(string[] args)
        {
            ClassRoom cRoom_1 = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new BadPupil());
            cRoom_1.PrintClassInfo();
            //Console.WriteLine("\n\n\n");
            ClassRoom cRoom_2 = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil());
            cRoom_2.PrintClassInfo();
            //Console.WriteLine("\n\n\n");
            ClassRoom cRoom_3 = new ClassRoom(new ExcelentPupil(), new GoodPupil());
            cRoom_3.PrintClassInfo();
        }
    }
}
