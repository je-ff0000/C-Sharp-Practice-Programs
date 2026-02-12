using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    partial class A
    {
        public string name { set; get; }
        public int age { set; get; }
    }

    partial class A
    {
        public string Phone { set; get; }
    }

    partial class A
    {
        public string Address { set; get; }
    }

    class B
    {
        static void Main(string[] args)
        {
            A ob = new A();

            ob.name = "John";
            ob.age = 23;
            ob.Phone = "2453210";
            ob.Address = "Kochi";

            Console.WriteLine("Name: {0}", ob.name);
            Console.WriteLine("Age: {0}", ob.age);
            Console.WriteLine("Phone: {0}", ob.Phone);
            Console.WriteLine("Address: {0}", ob.Address);

            Console.ReadKey();
        }
    }
}

