using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{// access keyword  type fn_name()
    public delegate int del(int a, int b);
    class Program
    {
        public int sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Program ob = new Program();

            del d = new del(ob.sum);
            int s = d(10, 20);
            Console.WriteLine("Sum: {0}", s);
            Console.ReadKey();
        }
    }
}
