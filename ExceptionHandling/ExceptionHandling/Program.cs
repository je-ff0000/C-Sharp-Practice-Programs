using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x;
                Console.WriteLine("Enter age:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x <= 0)
                {
                    throw new ArgumentException("Age cannot be less than zero");
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("In finally block");
            }

            Console.ReadKey();
        }
    }
}
