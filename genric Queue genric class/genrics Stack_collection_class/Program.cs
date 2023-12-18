using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_collection_class
{
    class Program
    {
        static void Main(string[] args)
        {   
            Stack<int> roomnum = new Stack<int>();
            roomnum.Push(1);
            roomnum.Push(2);
            roomnum.Push(3);
            roomnum.Push(4);    
            roomnum.Push(5);

            foreach (int item in roomnum)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            //roomnum.Pop(2);
            //Console.WriteLine(2);


            roomnum.Peek();
            Console.WriteLine(2);

            int count = roomnum.Count();
            Console.WriteLine(count);



            Console.ReadLine();
        }
    }
}
