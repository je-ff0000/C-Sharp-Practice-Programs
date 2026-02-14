using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        public static void Main()
        {
            int[] ar = new int[5];
            Console.WriteLine("Enter the elements");

            for(int i = 0; i < 5; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array elements are");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
