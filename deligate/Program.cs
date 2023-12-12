using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligate
{     
    public delegate void Calculation(int a , int b); //create a delegate with same return type
    //and same paramiters int a and int b 
    class Program
    {   
        public static void Addition(int a ,int b ) //method with two veriables int a and int b 
        {
            int result = a + b; //resulat named variable 
            Console.WriteLine($"addition result is : {result}"); // and print the result 
        }
        public static void subtraction(int a, int b) //method with two veriables int a and int b 
        {
            int result = a - b; //resulat named variable 
            Console.WriteLine($"subtraction result is : {result}"); // and print the result 
        }
        public static void multification(int a, int b) //method with two veriables int a and int b 
        {
            int result = a * b; //resulat named variable 
            Console.WriteLine($"multification result is : {result}"); // and print the result 
        }
        public static void division(int a, int b) //method with two veriables int a and int b 
        {
            int result = a / b; //resulat named variable 
            Console.WriteLine($"division result is : {result}"); // and print the result 
        }
        static void Main(string[] args)
        {//                       delegae cunstructor, who wants you call add that name in this addition 
            Calculation obj = new Calculation(Program.Addition); //now we make delegae type refrence type 
            obj.Invoke(10,20);
            Calculation obj1 = new Calculation(Program.subtraction); //now we make delegae type refrence type 
            obj.Invoke(30, 20);
            Calculation obj2 = new Calculation(Program.multification); //now we make delegae type refrence type 
            obj.Invoke(2, 5);
            Calculation obj3 = new Calculation(Program.division); //now we make delegae type refrence type 
            obj.Invoke(10, 5);




            //obj = subtraction;//second way to call delegate method 
            //obj(20, 34);

            //obj = multification;
            //obj(20, 344);

            //obj = division;
            //obj(12, 56);
            
            Console.ReadLine();

        }
    }
}
