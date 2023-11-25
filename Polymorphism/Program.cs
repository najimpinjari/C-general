using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
       public void sum( int a ,int b )    
        {
            Console.WriteLine(a + b);
        }

        public void sum(float a , float b)
        {
            Console.WriteLine(a+b);
        } 

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.sum(10, 20);




            Console.ReadLine();

        }


    }
}
