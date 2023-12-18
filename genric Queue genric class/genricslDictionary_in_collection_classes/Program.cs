using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_in_collection_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , int> myroom = new Dictionary<string , int>();
            myroom.Add("radhes", 1);
            myroom.Add("gotya", 2);
            myroom.Add("prathm", 3);

            //foreach (var keys in myroom)
            //{
            //    Console.WriteLine(keys);
            //}

            //Console.WriteLine("------------------");

            //foreach (var values in myroom)
            //{
            //    Console.WriteLine(values);
            //}

            myroom.Add("vedant", 4); //ading item 
            foreach (var keys in myroom)
            {
                Console.WriteLine(keys);
            }

              int vedantnum = myroom["vedant"];

            Console.WriteLine(vedantnum);

            bool hasgotya = myroom.ContainsKey("gotya");

            Console.WriteLine(hasgotya);

            myroom.Clear();

            Console.ReadLine();
        }
    }
}
