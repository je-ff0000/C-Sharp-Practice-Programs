using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testqn1
{
    interface A
    {
        void sum(int x, int y, int z);
    }

    interface B
    {
        void product(int x, int y, int z);
    }

    class C : A, B
    {
        public int n1 { set; get; }
        public int n2 { set; get; }
        public int n3 { set; get; }


        public void sum(int x, int y, int z)
        {
            Console.WriteLine("Sum: {0}", x + y + z);
        }

        public void product(int x, int y, int z)
        {
            Console.WriteLine("Product: {0} ", x * y * z);
        }
        static void Main(string[] args)
        {
            C ob = new C();
            Console.WriteLine("Enter three numbers");
            ob.n1 = Convert.ToInt32(Console.ReadLine());
            ob.n2 = Convert.ToInt32(Console.ReadLine());
            ob.n3 = Convert.ToInt32(Console.ReadLine());
            
            ob.sum(ob.n1, ob.n2, ob.n3);
            ob.product(ob.n1, ob.n2, ob.n3);

            Console.ReadKey();
        }
    }
}
