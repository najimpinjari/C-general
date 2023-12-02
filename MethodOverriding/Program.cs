using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class a
    {
        public virtual void M1() //method
        {
            Console.WriteLine("Method of base class "); //method body
        }
    }
    public class b : a 
    {
        public override void M1()
        {
            Console.WriteLine("Method of derived // child  class ");
        }


    }

    public class c
    {
        public static void Main()
        {
            b b1 = new b();// object 
            b1.M1();// calling the obj
            Console.ReadLine();
        }
    }

}