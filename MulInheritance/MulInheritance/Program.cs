using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulInheritance
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
    class B : A
    {
        public int s;
        public void sum()
        {
            s = a + b;
            Console.WriteLine("Sum: {0}", s);
        }
    }

        class C : B
    {   public int av;
        public void average()
        {
                av = s / 2;
            Console.WriteLine("Average: {0}", av);
        }
        static void Main(string[] args)
        {
            C ob = new C();

            ob.read();
            ob.sum();
            ob.average();

            Console.ReadKey();
        }
    }
}
