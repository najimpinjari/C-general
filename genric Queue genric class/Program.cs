using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_genric_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> name = new Queue<string>();
            name.Enqueue("radhesh");
            name.Enqueue("gotya");
            name.Enqueue("najim");

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");
            
            string namenew = name.Dequeue();
            Console.WriteLine(namenew); // gives you first values or string

            string name2 = name.Peek();
            Console.WriteLine(name2);


            foreach (var item in name)
            {
                Console.WriteLine(item);
            }




            Console.ReadLine();
        }
    }
}
