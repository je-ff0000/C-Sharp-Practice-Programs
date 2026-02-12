using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQn2
{
    abstract class P
    {
        public abstract void ifPalindrome(string s);
    }
    class A: P
    {   public override void ifPalindrome(string s)
        {
            int flag = 0, n;
            n = s.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (s[i] != s[n - i - 1])
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("String is Palindrome");
            else
                Console.Write("String is not Palindrome");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            A ob = new A();
            Console.Write("Enter a string: ");
            s = Console.ReadLine();
            ob.ifPalindrome(s);
            Console.ReadKey();
        }
    }
}
