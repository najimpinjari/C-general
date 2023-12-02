using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = "abhishek";
            Console.WriteLine(n);
            Console.WriteLine(n.GetType());

            var s = 100;
            Console.WriteLine(s);
            Console.WriteLine(s.GetType());

            var a = 10f;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            var b = 455m;
            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            var d = true;
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());


            






            Console.ReadLine();

        }
    }
}
