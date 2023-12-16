using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_stack
{
     class Program
    {
        static void Main(string[] args)
        {   
            Stack<int> newstack = new Stack<int>();
            {
                newstack.Push(1);
                newstack.Push(2);
                newstack.Push(3);
                newstack.Push(4);
                newstack.Push(5);
                newstack.Push(6);
            }


            foreach (int i in newstack)
            {
                Console.WriteLine(i);
            }
            newstack.Pop();
            Console.WriteLine("afer pop of the element");

            foreach (int j in newstack)
            {
                Console.WriteLine(j);
            }




            Console.ReadLine();
        }
    }
}
