using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1, c1, r2, c2;

            Console.Write("Enter row size for matrix 1: ");
            r1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter column size for matrix 1: ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter row size for matrix 2: ");
            r2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter column size for matrix 2: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            if(r2 == c1)
            {
                Console.WriteLine("Enter elements for matrix 1");

            }



        }
    }
}
