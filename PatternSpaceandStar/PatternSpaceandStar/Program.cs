using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSpaceandStar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter a limit:");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i + j >= n - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
