using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class gen<X, Y>
    {
        public X a;
        public Y b;
        public gen(X i, Y j)
        {
            a = i;
            b = j;
        }
    }
    class A 
    { 
        static void Main(string[] args)
        {
            int n, m;

            Console.WriteLine("Enter 2 numbers:");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            gen<int, int> obj = new gen<int, int>(n, m);
            Console.WriteLine("sum is {0}", obj.a + obj.b);
            gen<string, string> obj1 = new gen<string, string>("HI ", "Everyone");
            Console.WriteLine("string is {0}", obj1.a + obj1.b);

            Console.ReadKey();
        }
    }
}
