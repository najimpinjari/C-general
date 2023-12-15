using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Method
{
    static class MyStaticClass
    {
        public static void Funk3(this Program pm)
        {
            Console.WriteLine("this is third program ");
        }

    }

}
