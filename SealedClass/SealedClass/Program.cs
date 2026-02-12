using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    sealed class A
    {
        public void display()
        {
            Console.WriteLine("Sealed Class");
        }
        static void Main(string[] args)
        {
            A ob = new A();

            ob.display();

            Console.ReadKey();
        }
    }
}
