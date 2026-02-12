using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n1 = 0, n2 = 1, temp;

            Console.Write("Enter the limit: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series");
            Console.Write("{0} {1} ", n1, n2);
            for(int i = 2; i <= n; i++) 
            {
                temp = n2;
                Console.Write("{0} ", n1 + n2);
                n2 += n1;
                n1 = temp;
            }

            Console.ReadKey();
        }
    }
}
