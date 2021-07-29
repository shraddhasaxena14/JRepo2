using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionEg
{
    class CollectionDemo
    {
        static void ArrayEg()
        {
            ArrayList al = new ArrayList();

            //capacity is used to find the capacity of array and how it changes after adding and deleting items of array
            Console.WriteLine("capacity {0}", al.Capacity);
            al.Add(10);
            Console.WriteLine("capacity {0}", al.Capacity);
            al.Add("Devi");
            al.Add(100.0f);
            Console.WriteLine("capacity {0}", al.Capacity);
            al.Add("a");
            Console.WriteLine("capacity {0}", al.Capacity);
            al.Add(20);
            Console.WriteLine("capacity {0}", al.Capacity);
            foreach (var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }
            //properties of arraylist
            Console.WriteLine("Count is {0}", al.Count);
            Console.WriteLine("Index of is {0}", al.IndexOf(20));
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Remove("Devi");
            al.Remove(20);
            foreach(var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }
            Console.WriteLine("capacity {0}", al.Capacity);

        }

        //Combination of key and value pair
        static void HashTableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("N", "Networks");
            ht.Add("O", "operating Syatem");
            ht.Add("J", "Java");
            ht.Add("U", "Unix");

            //properties
            Console.WriteLine(ht.Contains("O"));
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " : " + d.Value);
            }


        }
        //Combination of key and value pair just in sorted order
        static void SortedListEg()
        {
            SortedList sl = new SortedList();
            sl.Add("N", "Networks");
            sl.Add("O", "operating Syatem");
            sl.Add("J", "Java");
            sl.Add("U", "Unix");

            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + " : " + d.Value);
            }

        }


        static void Main()
        {
            ArrayEg();
            Console.WriteLine("Hashtable");
            HashTableEg();
            Console.WriteLine("SortedList");
            SortedListEg();
        }
    }
}
