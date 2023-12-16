using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Class_Hashtable
{
    class Program
    {
        public static object Keys { get; private set; }

        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "najim");
            ht.Add(2, "sham");
            ht.Add(3, "gotya");


            Console.WriteLine(ht.Count);
            Console.WriteLine(ht.Keys);
            Console.WriteLine(ht.Values);


            //Console.WriteLine(ht.Count("najim"));
            //Console.WriteLine(ht.Contains(2));
            //Console.WriteLine(ht.ContainsValue("najim")); //for finding keys or vlues k


            //Console.WriteLine(ht[3]); //call or display the 3rd values using key 

            //foreach (object key in  ht.Keys) 
            //{
            //    Console.WriteLine( key + "  : " +ht[key]);
            //}


            ////ht.Clear();
            //////ht.Remove(1);
            //Console.WriteLine("------------");


            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key + "  : " + ht[key]);
            //}



            //foreach (var item in ht)
            //{
            //    Console.Write(ht[1]);
            //}
            //Console.WriteLine();


            Console.ReadLine();
        }
    }
}

