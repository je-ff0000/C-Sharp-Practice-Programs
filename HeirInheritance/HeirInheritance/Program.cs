using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirInheritance
{
    class A
    {
        public int a, b;
        public void read()
        {
            Console.Write("Enter A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter B: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
    }

    class B: A
    { 
        public void sum()
        {
            Console.WriteLine("Sum: {0}", a + b);
        }
    }

    class C: A
    {
        public void average()
        {
            Console.WriteLine("Average: {0}", (a + b) / 2);
        }
    }

    class D: A
    {
        void product()
        {
            Console.WriteLine("Product: {0}", a * b);
        }
        static void Main(string[] args)
        {
            B obb = new B();
            obb.read();
            obb.sum();
            C obc = new C();
            obc.read();
            obc.average();
            D ob = new D();
            ob.read();
            ob.product();

            Console.ReadKey();
        }
    }
}
