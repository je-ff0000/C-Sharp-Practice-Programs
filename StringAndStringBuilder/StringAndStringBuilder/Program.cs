using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "Good Morning";
            String b = "Hello Friend";
            String c = a.Clone().ToString();
            Console.WriteLine(c);

            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(a.CompareTo(a));

            Console.WriteLine(a.Equals(a));
            Console.WriteLine(a.Equals(b));

            Console.WriteLine(a.StartsWith("g"));
            Console.WriteLine(b.EndsWith("d"));

            Console.WriteLine(a.Contains("Good"));
            Console.WriteLine(b.Contains("morning"));

            Console.WriteLine(b.GetType());

            Console.WriteLine(a.IndexOf("o"));
            Console.WriteLine(a.LastIndexOf("o"));

            Console.WriteLine(b.ToUpper());
            Console.WriteLine(b.ToLower());

            int l = b.Length;
            Console.WriteLine("Length of b: {0}", l);

            String s = " Hi Hello ";
            Console.WriteLine(s.Trim());

            String a1 = "Good Morning";
            String x = a1.Insert(0, "hi.."); //Inserts argument string to 0th index of a1
            Console.WriteLine(x);

            String b1 = "Hello Friend";
            Console.WriteLine(b1.Remove(7)); // Removes characters from 7th index

            String a2 = "Good Morning";
            Console.WriteLine(a2.Substring(2, 5)); //Returns 5 character from 2nd index 

            String d = "Hi how are you";
            char[] ar = new char[15];
            d.CopyTo(0, ar, 0, 6); //From d's 0th index copy to ar's 0th index 6 characters

            foreach (char ch in ar)
                Console.Write(ch);
            Console.WriteLine();


            string s1 = "";
            StringBuilder sb = new StringBuilder("");
            sb.Append("hello");
            sb.AppendLine();
            sb.Append("welcome to our program");
            Console.WriteLine(sb);


            Console.ReadKey();
        }
    }
}
