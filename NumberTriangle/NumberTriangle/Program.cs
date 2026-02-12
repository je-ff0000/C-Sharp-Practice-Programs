using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num;
            Console.WriteLine("Enter a limit: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                num = 1;
                for (int j = 0; j < n + i; j++)
                { 
                    if (j < n - i - 1)
                        Console.Write(" ");
                    else
                    {
                        Console.Write(num);
                        num = j < n - 1 ? ++num : --num;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
