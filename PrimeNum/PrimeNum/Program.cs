using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cnt = 0;

            Console.Write("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    cnt++;
                    break;
                }
            }

            if (cnt > 0)
                Console.WriteLine("Not a Prime number");
            else
                Console.WriteLine("Prime number");

            Console.ReadKey();
                    
            }
        }
    }

