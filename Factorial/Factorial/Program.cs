using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, f = 1;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine("{0}! : {1}", n, f);

            Console.ReadKey();
        }

    }
}
