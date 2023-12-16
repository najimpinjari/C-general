using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> newstack = new Queue<int>();
            {
                newstack.Enqueue(1);
                newstack.Enqueue(2);
                newstack.Enqueue(3);
                newstack.Enqueue(4);
                newstack.Enqueue(5);
                newstack.Enqueue(6);
            }


            foreach (var j in newstack)
            {
                Console.WriteLine(j);
            }
            newstack.Dequeue();
            newstack.Dequeue();
            newstack.Dequeue();

            Console.WriteLine("afer dequeue of the element");

            foreach (int j in newstack)
            {
                Console.WriteLine(j);
            }




            Console.ReadLine();
        }
    }
}
