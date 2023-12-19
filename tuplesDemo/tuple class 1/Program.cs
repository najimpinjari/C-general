using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuple_class_1
{
    class Program
    {
        static void Main()
        {
            //creating a tuple with two elements int and sring 

            Tuple<int, string> mytuple = new Tuple<int, string>(42, "hello world");
            

            //accesing the item of the tuple 
            int intvalue = mytuple.Item1;
            string stringvalues = mytuple.Item2;

            //disply a values 
            Console.WriteLine(stringvalues);
            Console.WriteLine(intvalue);

            //createing a tuple using literes 
            var anothertuple = (10, "c# tuple");

            var (number , message ) = anothertuple;

            Console.WriteLine($" numbers {number}");
            Console.WriteLine($" message  {message}");
            Console.ReadLine();

        }
    }
}
