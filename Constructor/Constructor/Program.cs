using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class A
    {
        public A()
        {
            Console.WriteLine("Default Constructor");
        }

        public A(int a, int b)
        {
            Console.WriteLine("Sum: {0}", a + b);
        }

        static A()
        {
            Console.WriteLine("Static Constructor");
        }
        static void Main(string[] args)
        {
            A ob = new A();
            A obj = new A(10, 20);

            Console.ReadKey();
        }
    }
}
