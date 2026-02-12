using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumUptoN
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end, cnt;

            Console.Write("Enter start limit:");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end limit:");
            end = Convert.ToInt32(Console.ReadLine());



            for (int i = start; i <= end; i++)
            {   cnt = 0;

                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                    Console.Write(" {0}", i);
            }

            Console.ReadKey();
        }
    }
}
