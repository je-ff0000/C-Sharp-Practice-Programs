using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, rev = "";
            string[] words;
            Console.Write("Enter a string: ");
            s = Console.ReadLine();
            words = s.Split();

            for (int i = words.Length - 1; i >= 0; i--)
                rev = rev + words[i] + " ";
            Console.WriteLine("Words in reverse order: {0}", rev);
            Console.ReadKey();
            
        }
    }
}
