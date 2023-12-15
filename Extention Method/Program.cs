using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Method
{
    class Program
    {   
        public void Funk1()
        {
            Console.WriteLine("this is first function ");
        }

        public void Funk2()
        {
            Console.WriteLine("this is second function ");
        }

        static void Main(string[] args)
        {
            Program pm = new Program();
            pm.Funk1();
            pm.Funk2();
            pm.Funk3();

            Console.ReadLine();


        }
    }
}
