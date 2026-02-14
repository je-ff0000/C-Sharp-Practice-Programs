using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumUptoN
{
    class Program
    {
        public static void Main()
        {
            int start, end, cnt;

            Console.Write("Enter start limit:");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end limit:");
            end = Convert.ToInt32(Console.ReadLine());



            for (int i = start; i <= end; i++)
            {   cnt = 0;

                if(i <= 1)
                {
                    continue;
                }

                if( i == 2 || i == 3)
                {
                    Console.Write(" {0}", i);
                }

                if(i % 2 == 0 || i % 3 == 0)
                {
                    continue;
                }
                for(int j = 5; j <= Math.Sqrt(i); j += 6)
                {

                    if (i % j == 0 || i % (j + 2) == 0)
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
