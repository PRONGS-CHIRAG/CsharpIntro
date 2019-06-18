using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Csharp
{
    class Collections
    {
        static void Main(string [] args)
        {
            ArrayList a = new ArrayList();
            a.Add(2);
            a.Add(87);
            ArrayList b = new ArrayList() { 1, 45, 67, 897, 654 };
            b.Insert(1, 84);
            foreach ( var val in a)
            {
               // Console.WriteLine(val);
            }
            Console.WriteLine("\n");
            foreach(var val in b)
            {
               // Console.WriteLine(val);
            }

            //Console.ReadLine();
            SortedList c = new SortedList();
            c.Add(1, "One");
            c.Add(2, "Two");
            c.Add(3, "three");
            SortedList d = new SortedList();
            d.Add("one", 1);
            d.Add("two", 2);
            d.Add("three", 3);
            d.Remove("one");
            d.RemoveAt(1);
            SortedList e = new SortedList()
            {
                {1,"one" },{2,"two"},{3,"three"},{4,"four"}
            };
            for(int i = 0; i < d.Count; i++)
            {
                Console.WriteLine("key : {0}    value : {1}", d.GetKey(i), d.GetByIndex(i));
            }
            foreach(DictionaryEntry ar in e)
            {
                /Console.WriteLine("key : {0}    value : {1}", ar.Key, ar.Value);
            }

            Hashtable f = new Hashtable()
            {
                {1,"one" },{2,"two"},{3,"three"},{4,"four"},{5,"five"}
            };
            //f.Add(6, "Six");
            foreach( DictionaryEntry al in f)
            {
                //Console.WriteLine("key : {0}    value : {1}", al.Key, al.Value);
            }
           // Console.WriteLine("Before clearing Count : {0}", f.Count);
            f.Clear();
            //Console.WriteLine("After clearing Count : {0}", f.Count);
            Stack g = new Stack();
            g.Push(1);
            g.Push(2);
            g.Push(3);
            g.Push(4);
            g.Push(5);
            //Console.WriteLine(g.Peek());
           // Console.WriteLine("\n");
            foreach (var ap in g)
            {
               // Console.WriteLine(ap);
            }
            //Console.WriteLine("\n");
            g.Pop();
            foreach(var ap in g)
            {
               // Console.WriteLine(ap);
            }
            g.Clear();
            Queue h = new Queue();
            h.Enqueue(1);
            h.Enqueue(2);
            h.Enqueue(3);
            h.Enqueue(4);
            h.Enqueue(5);
            foreach (var ap in h)
            {
                //Console.WriteLine(ap);
            }
            h.Dequeue();
            Console.WriteLine("\n");
            foreach (var ap in h)
            {
                //Console.WriteLine(ap);
            }
            //Console.WriteLine(h.Peek());
            h.Clear();
            int[][] jaggedarray = new int[2][];
            jaggedarray[0] = new int[3] { 1, 2, 3 };
            jaggedarray[1] = new int[4] { 6, 7, 8, 9 };
            Console.WriteLine(jaggedarray[0][0]);
            Console.WriteLine(jaggedarray[0][1]);
            Console.WriteLine(jaggedarray[1][2]);
            Console.WriteLine(jaggedarray[1][3]);
            Console.ReadLine();
        }

    }
}
