using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface A
    {
        void sum(int x, int y);
    }

    interface B
    {
        int product();
    }

    class C: A,B
    {
        public void sum(int x, int y)
        {
            Console.WriteLine("Sum: {0}", x + y);
        }

        public int product()
        {
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            return a * b;
        }
        static void Main(string[] args)
        {
            C ob = new C();
            ob.sum(3, 5);
            int p = ob.product();
            Console.WriteLine("Product: {0}", p);

            Console.ReadKey();
        }
    }
}
