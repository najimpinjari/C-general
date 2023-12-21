using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoynimusFunction
{
    public delegate int Mydeligatenew(int num); //diclaring delegate in first in globle variable for all one access easily 

    class Program
    {

        //public static void Mymethodone(int a) //<---delegate and there parameter should be same otherwise they show compiler error 
        //    //it help mymethods refrence we can use mydelegates object store or use it 
        //{
        //    a += 10;
        //    Console.WriteLine(a);

        //}


        static void Main(string[] args)//now wi can call this mathod with help of delegate 
        {
            //class method always call with there name always 

            //first we create the obj of my delegate obj
            //second in my delegate constractor () will fill the theose object that he pointing rimember


            //Mydeligatenew obj = new Mydeligatenew(Program.Mymethodone);

            Mydeligatenew obj = delegate (int a) //this is a anoynimus method and wi can call teh method usign delegate 
            {
                a += 10;
                //Console.WriteLine(a);
                return a;   
            };

            //obj.Invoke(3); //fist way to call 
            //obj(3);  //it also same result 

            Console.WriteLine(obj.Invoke(3));

            Console.ReadLine();

        }
    }
}   
