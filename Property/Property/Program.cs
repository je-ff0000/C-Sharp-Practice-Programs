using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class A
    {
        public int P1 { set; get; }
        public int P2 { set; get; }

        static void Main(string[] args)
        {
            A ob1 = new A();
            A ob2 = new A();
            Console.WriteLine("Enter two numbers");
            ob1.P1 = Convert.ToInt32(Console.ReadLine());
            ob2.P1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sum: {0}", ob1.P1 + ob2.P1);

            Console.ReadKey();

        }
    }
}
