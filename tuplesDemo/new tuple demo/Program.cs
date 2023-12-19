using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_tuple_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Tuple<int, int, int> t1 = new Tuple<int, int, int>(11, 12, 13);

            Console.WriteLine(t1.Item2);

            Tuple<int, int, int, int, int, int, int> number = new Tuple<int, int, int, int, int, int, int> (1, 2, 3, 4, 5, 6, 7);

            Console.WriteLine(number.Item3);
            Console.WriteLine(number.Item4);


            Console.ReadLine();
        }
    }
}
