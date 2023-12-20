using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeild_demo_2
{
    class Program
    {
        static List<int> mylist = new List<int>();
        static void fillvalues()
        {
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);
            mylist.Add(7);
        }

        static void main(string[] args)
        {
            fillvalues();
            foreach (int i in mylist)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
