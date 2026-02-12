using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, temp;

            Console.Write("Enter size of array: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[n];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < n; i++)
                A[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] > A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }

            Console.WriteLine("After Sorting");

            for (int i = 0; i < n; i++)
                Console.Write("{0} ", A[i]);

            Console.ReadKey();
        }
    }
}
