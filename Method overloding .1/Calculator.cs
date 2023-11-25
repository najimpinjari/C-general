using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloding._1
{
    public class Calculator
    {
        public void print() // Method  
        {
            Console.WriteLine("print() called ");
        }

        public void print(int num) // Method  
        {
            Console.WriteLine("print(10) called ");
        }

        public void print(ref int num) // Method  
        {
            Console.WriteLine("print(ref int num) called ");
        }

        public void print(int num1, int num2) // Method  
        {
            Console.WriteLine("print(int num1, int num2)) called ");
        }

        public void print(string name ) // Method  
        {
            Console.WriteLine("print( string name ) called ");
        }

        public void print(int num3 ,string name) // Method  
        {
            Console.WriteLine("print( int num3 ,string name ) called ");
        }

        public void print( string name1, int num4) // Method  
        {
            Console.WriteLine("print( string name1, int num4e ) called ");
        }

    }
}
