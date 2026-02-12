using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x= 65;

            Console.Write("Enter limit: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++, x++)
                {
                    Console.Write("{0} ", (char)x);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
