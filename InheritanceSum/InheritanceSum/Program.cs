using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSum
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
        static void Main(string[] args)
        {
            B ob = new B();

            ob.read();
            ob.sum();

            Console.ReadKey();
        }
    }
}
