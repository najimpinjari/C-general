using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expression
{
    public delegate void Mydelegate(int num); //delegate we use another function pointing   
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate obj = /*delegate*/ (/*int*/ a) =>  //anonynimus function , look the (int a )( int num) my delegate and there objects signature should 
            //same at every time to do   
                                               //the above arrow is lambda expression 
            {
                a += 5;
                Console.WriteLine(a);
            };

            obj.Invoke(10); //for callind method 
            Console.ReadLine(); //for holding console windo
        }
    }
}
