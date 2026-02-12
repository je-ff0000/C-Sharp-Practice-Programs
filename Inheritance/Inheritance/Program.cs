using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
    {
        public void displayA()
        {
            Console.WriteLine("Class A");
        }
    }
    class B: A
    {
        public void displayB()
        {
            Console.WriteLine("Class B");
        }
        static void Main(string[] args)
        {
            B ob = new B();
            ob.displayA();
            ob.displayB();
            Console.ReadKey();
        }
    }
}
