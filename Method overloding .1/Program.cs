using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloding._1
{
     class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(); //object of the class 
            c1.print(); //called method 
                        //we can pass the argument over here    

            c1.print(10);

            int i = 1000;
            c1.print(ref i );

            c1.print(10, 20);

            c1.print("radhesh");

            c1.print(1,"sham");

            c1.print("prathm", 1);







            Console.ReadLine();
        }
    }
}
