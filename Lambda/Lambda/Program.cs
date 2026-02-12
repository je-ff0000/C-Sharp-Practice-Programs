using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 37, 71, 12, 15, 29, 18, 27, 17, 9, 34 };
            Console.Write("List: ");

            foreach( var value in numbers)
            {
                Console.Write("{0} ", value);
            }

            Console.WriteLine();

            var square = numbers.Select(x => x * x);

            Console.Write("Squares: ");
            foreach(var value in square)
            {
                Console.Write("{0} ", value);
            }

            Console.WriteLine();

            List<int> div3 = numbers.FindAll(x => x % 3 == 0);

            Console.Write("Numbers divisible by 3: ");
            foreach(var value in div3)
            {
                Console.Write("{0} ", value);
            }

            Console.ReadKey();

        }
    }
}
