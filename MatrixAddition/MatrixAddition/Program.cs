using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c;

            Console.Write("Enter row size: ");
            r = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter column size: ");
            c = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[r, c];
            int[,] B = new int[r, c];
            int[,] C = new int[r, c];

            Console.WriteLine("Enter elements of Matrix A");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements of Matrix B");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write("{0} ", C[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix C");


            Console.ReadKey();
        }
    }
}
