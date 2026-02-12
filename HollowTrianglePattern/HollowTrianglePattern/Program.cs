using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HollowTrianglePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;

            Console.Write("Enter limit: ");
            rows = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < rows + i; j++)
                if ((j < rows - i - 1) || (j - i != rows - 1 && i != 0 && i != rows - 1 && j + i != rows - 1))
                    Console.Write(" ");
                else
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
