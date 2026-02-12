using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOverLoading
{
    class A
    {
        public void sum()
        {
            int x, y;
            Console.WriteLine("Enter 2 numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum: {0}", x + y);
        }

        public void sum(int x, int y)
        {
            Console.WriteLine("Sum: {0}", x + y);
        }

        public double sum(double d1, double d2)
        {
            return d1 + d2;
        }
        public static void Main(string[] args)
        {
            A ob = new A();
            ob.sum();
            ob.sum(3, 5);
            double a, b;
            Console.WriteLine("Enter 2 double numbers");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            double dsum = ob.sum(a, b);
            Console.WriteLine("Sum: {0}", dsum);

            Console.ReadKey();
        }

    }
}
