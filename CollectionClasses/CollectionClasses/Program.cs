using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //al.Add(100);
            //al.Add(200);
            //al.Add(300);
            //al.Add(400);
            ////al.Add("hi");

            //al.Insert(1, 1500);

            //al.Sort();
            //al.Remove(200); //removes 200
            //al.RemoveAt(2); //removes values at index 2
            //Console.WriteLine("Added Items");

            //for(int i = 0; i < al.Count; i++)
            //{
            //    Console.WriteLine(al[i]);
            //}

            //Hashtable ht = new Hashtable();

            //ht.Add(4, "red");
            //ht.Add(21, "green");
            //ht.Add(48, "blue");
            //ht.Add(2, "hhh");

            //foreach(DictionaryEntry i in ht)
            //{
            //    Console.WriteLine(i.Key + ": " + i.Value);
            //}

            //Console.WriteLine("Value of key 4: {0}", ht[4]);

            SortedList sl = new SortedList();

            sl.Add(1, "red");
            sl.Add(4, "green");
            sl.Add(3, "blue");
            sl.Add(2, "yellow");

            foreach(DictionaryEntry i in sl)
            {
                Console.WriteLine(i.Key + ": " + i.Value);
            }

            Console.ReadKey();
        }
    }
}
