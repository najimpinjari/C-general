using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates._2
{
    public delegate void servicedelegates(string message);
    public class Manufacturer
    {   
        private servicedelegates _servicedelegates;

        public void ManufactureItem()
        {
            Console.WriteLine("manufacture item 1 ");
            Console.WriteLine("manufacture item 2 ");
            Console.WriteLine("manufacture item 3 ");
            Console.WriteLine("manufacture item 4 ");

            this._servicedelegates("item 5");

            Console.ReadLine();

        }
        public void Registerserviceprovider(servicedelegates servicedelegates)
        {
            this._servicedelegates = servicedelegates;
        }



    }
}
