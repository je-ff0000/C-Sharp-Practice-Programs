using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOverriding
{
    class A
    {
        public virtual void display()
        {
            Console.WriteLine("Base Function");
        }
    }
    class B: A
    {
        public override void display()
        {
            Console.WriteLine("Derived function");
        }
        static void Main(string[] args)
        {
            B ob = new B();
            ob.display();
            Console.ReadKey();
        }
    }
}
