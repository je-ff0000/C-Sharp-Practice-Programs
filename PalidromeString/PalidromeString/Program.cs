using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalidromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int flag = 0, n;
            Console.Write("Enter a string:");
            s = Console.ReadLine();
            n = s.Length;
            for (int i = 0; i < n / 2; i++)
                if (s[i] != s[n - i - 1])
                {
                    flag = 1;
                    break;
                }
            if (flag == 0)
                Console.Write("String is Palindrome");
            else
                Console.Write("String is not Palindrome");

            Console.ReadLine();
        }
    }
}
