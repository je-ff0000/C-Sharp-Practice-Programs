using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //To Print all Armstrong numbers from start to limit
            int m, count, c, sum, p, limit, start = 153;
            Console.WriteLine("Enter a number:");
            limit = Convert.ToInt32(Console.ReadLine());
            while(start < limit)
            {
                m = start;
                count = 0;
                while (m > 0)
                {
                    count++;
                    m /= 10;
                }

                m = start;
                sum = 0;
                while (m > 0)
                {
                    c = count;
                    p = 1;
                    while (c > 0)
                    {
                        p *= m % 10;
                        c--;
                    }
                    sum += p;
                    m /= 10;
                }

                if(sum == start)
                {
                    Console.Write("{0} ", sum);
                }
                
                start++;
            }
           

            Console.ReadKey();
        }
    }
}
