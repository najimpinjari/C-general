using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate._1
{   delegate void calculator(int a , int b);
    class Program
    {   public static void Add(int a ,  int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            calculator clc = new calculator(Add);
            clc += Mul; //thats called malticast delegates 
            //delegated pointing more than one methods 
            clc(5, 20);

            //calculator clc1 = new calculator(Mul);// you should have add any mamth keyword here and then efect as follow 
            
            //clc1(20, 20); //  //call  delegate first way 

            Console.ReadLine();
        }
    }
}
