using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_as_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            object b = "naz";
            string c = b as string; //naz
            Console.WriteLine(c);

            object d = 234;
            string e = d as string;
            Console.WriteLine(e);  //null

            //object a = 345;
            //bool check = a is string;
            //Console.WriteLine(check); // false 

            //object a = "naz";
            //bool check = a is string;
            //Console.WriteLine(check); // true 

            Console.ReadLine();
        }
    }
}
