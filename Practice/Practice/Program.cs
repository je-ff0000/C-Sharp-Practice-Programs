using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1, c1, r2, c2;

            Console.Write("Enter row and column size of matrix a: ");
            r1 = Convert.ToInt32(Console.ReadLine());
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter row and column size of matrix b: ");
            r2 = Convert.ToInt32(Console.ReadLine());
            c2 = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[r1, c1];
            int[,] B = new int[r2, c2];

            if (r2 == c1)
            {
                Console.WriteLine("Enter elements of Matrix A");

                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Enter elements of Matrix B");

                for (int i = 0; i < r2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                int[,] C = new int[r1, c2];

                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        C[i, j] = 0;
                        for (int k = 0; k < c1; k++)
                        {
                            C[i, j] += A[i, k] * B[k, j];
                        }
                    }
                }

                Console.WriteLine("product");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        Console.Write(C[i, j] + " ");
                    }
                    Console.WriteLine();

                }

            }

            else
                Console.WriteLine("Can't multiply");

            Console.ReadKey();
        }
    }
}
