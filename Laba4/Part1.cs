using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        public class MyMatrix
        {
            public double[,] matrix;
            public int lines;
            public int columns;

            public MyMatrix(int lineCount, int columnCount)
            {
                matrix = new double[lineCount, columnCount];
                lines = lineCount;
                columns = columnCount;
                for (int i = 0; i < lineCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            public MyMatrix(int lineCount, int columnCount, int randBegin, int randEnd)
            {
                matrix = new double[lineCount, columnCount];
                lines = lineCount;
                columns = columnCount;
                Random rand = new Random();
                for (int i = 0; i < lineCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        int rnd = rand.Next(randBegin, randEnd);
                        matrix[i, j] = rnd;
                    }
                }
            }

            public double this[int elem1, int elem2]
            {
                get
                {
                    return matrix[elem1, elem2];
                }
                set
                {
                    matrix[elem1, elem2] = value;
                }
            }
            static public MyMatrix operator +(MyMatrix matx1, MyMatrix matx2)
            {
                MyMatrix newMatX = new MyMatrix(matx1.lines, matx1.columns);
                for (int i = 0; i < matx1.lines; i++)
                {
                    for (int j = 0; j < matx1.columns; j++)
                    {
                        newMatX[i, j] = matx1[i, j] + matx2[i, j];
                    }
                }
                return newMatX;
            }

            static public MyMatrix operator -(MyMatrix matx1, MyMatrix matx2)
            {
                MyMatrix newMatX = new MyMatrix(matx1.lines, matx1.columns);
                for (int i = 0; i < matx1.lines; i++)
                {
                    for (int j = 0; j < matx1.columns; j++)
                    {
                        newMatX[i, j] = matx1[i, j] - matx2[i, j];
                    }
                }
                return newMatX;
            }

            static public MyMatrix operator *(MyMatrix matx1, MyMatrix matx2)
            {
                MyMatrix newMatX = new MyMatrix(matx1.lines, matx1.columns);
                for (int i = 0; i < matx1.lines; i++)
                {
                    for (int j = 0; j < matx1.columns; j++)
                    {
                        newMatX[i, j] = 0;
                        for (int k = 0; k < matx1.columns; k++)
                        {
                            newMatX[i, j] += matx1[i, k] * matx2[k, j];
                        }
                    }
                }
                return newMatX;
            }

            static public MyMatrix operator *(MyMatrix matx1, double num)
            {
                MyMatrix newMatX = new MyMatrix(matx1.lines, matx1.columns);
                for (int i = 0; i < matx1.lines; i++)
                {
                    for (int j = 0; j < matx1.columns; j++)
                    {
                        newMatX[i, j] = matx1[i, j] * num;
                    }
                }
                return newMatX;
            }

            static public MyMatrix operator /(MyMatrix matx1, double num)
            {
                MyMatrix newMatX = new MyMatrix(matx1.lines, matx1.columns);
                for (int i = 0; i < matx1.lines; i++)
                {
                    for (int j = 0; j < matx1.columns; j++)
                    {
                        newMatX[i, j] = matx1[i, j] / num;
                    }
                }
                return newMatX;
            }

            public void print ()
            {
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{matrix[i,j]} ");
                    }
                    Console.WriteLine("\r");
                }
            }
        }


        static void Main(string[] args)
        {
            int line;
            int column;
            int range1;
            int range2;

            Console.WriteLine("\n***********MATRIX 1**********\n");

            Console.WriteLine("Enter number of rows of Matrix 1");
            line = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of colums of Matrix 1");
            column = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter lowest number of random for Matrix 1");
            range1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter highest number of random for Matrix 1");
            range2 = int.Parse(Console.ReadLine());

            MyMatrix matrix1 = new MyMatrix(line, column, range1, range2);

            Console.WriteLine("\n***********MATRIX 2**********\n");

            Console.WriteLine("Enter number of rows of Matrix 2");
            line = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of colums of Matrix 2");
            column = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter lowest number of random for Matrix 2");
            range1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter highest number of random for Matrix 2");
            range2 = int.Parse(Console.ReadLine());

            MyMatrix matrix2 = new MyMatrix(line, column, range1, range2);

            MyMatrix newmatrix = new MyMatrix(line, column);

            Console.WriteLine("Matrix 1");
            matrix1.print();

            Console.WriteLine("Matrix 2");
            matrix2.print();

            Console.WriteLine("Matrix 1 + Matrix 2");
            newmatrix = matrix1 + matrix2;
            newmatrix.print();

            Console.WriteLine("Matrix 1 - Matrix 2");
            newmatrix = matrix1 - matrix2;
            newmatrix.print();

            Console.WriteLine("Matrix 1 * Matrix 2");
            newmatrix = matrix1 * matrix2;
            newmatrix.print();

            Console.WriteLine("Enter number for multiplication on matrix:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Matrix 1 * a");
            newmatrix = matrix1 * a;
            newmatrix.print();

            Console.WriteLine("Matrix 1 / a");
            newmatrix = matrix1 / a;
            newmatrix.print();

        }
    }
}
