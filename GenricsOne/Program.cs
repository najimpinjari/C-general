using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricsOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator c1 = new Calculator();
            //bool b1 = c1.AreEqual(10, 10);
            //Console.WriteLine(b1); //true

            //b1 = c1.AreEqual(10, 11);
            //Console.WriteLine(b1); // false 

            //b1 = c1.AreEqual("NAZ", "NAJ");
            //Console.WriteLine(b1); // false 

            Calculator c1 = new Calculator();
            bool b1 = c1.AreEqual<int>(10, 10);
            Console.WriteLine(b1);//true

            b1 = c1.AreEqual<string>("a", "v");
            Console.WriteLine(b1); // false

            b1 = c1.AreEqual<float>(10.3f, 4.2f);
            Console.WriteLine(b1); //false

            Console.ReadLine();
        }
    }
}
