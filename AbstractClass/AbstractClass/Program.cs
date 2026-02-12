using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class A
    {
        public abstract int reverse(int num);
    }

    class B: A
    {
        public override int reverse(int num)
        {
            int rev = 0;
            while(num > 0)
            {
                rev = rev * 10 + (num % 10);
                num /= 10;
            }
            return rev;

        }
        static void Main(string[] args)
        { 
            int num;
            B ob = new B();
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            int reverse = ob.reverse(num);
            Console.WriteLine("Reverse: {0}", reverse);

            Console.ReadKey();
        }
    }
}
