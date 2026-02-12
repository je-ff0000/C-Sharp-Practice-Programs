using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int count = 0;
            Console.Write("Enter a string: ");
            s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
                if (s[i] == ' ')
                    count++;

            count++;
            Console.Write("Number of words: {0}", count);

            Console.ReadKey();
        }
    }
}
