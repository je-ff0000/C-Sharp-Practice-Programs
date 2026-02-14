using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *
             **
             ***
             ****
             ***
             **
             *
             */ 
            int n, stars;
            Console.WriteLine("Enter a limit: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 2 * n; i++)
            {   if (i <= n)
                    stars = i;
                else
                    stars = 2 * n - i;
                for (int j = 1; j <= stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
