using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    public delegate void del(int a, int b);
    class Program
    {
        public void sum(int x, int y)
        {
            Console.WriteLine("Sum : {0}", x + y);
        }

        public void product(int x, int y)
        {
            Console.WriteLine("Product: {0}", x * y);
        }

        public static void Main(string[] args)
        {
            Program ob = new Program();
            del d = new del(ob.sum);

            d += new del(ob.product);

            d(10, 20);
            Console.ReadKey();
        }
    }
}
