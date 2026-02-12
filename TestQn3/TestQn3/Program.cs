using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQn3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string s = "";

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                s = "";
                if (i % 3 == 0)
                    s += "three";
                if (i % 5 == 0)
                    s += "five";
                if (s == "")
                    Console.Write(i);
                else
                    Console.Write(s);
                
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
