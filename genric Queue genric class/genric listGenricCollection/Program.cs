using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listGenricCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>(); //syntax of genric list 
            l1.Add(1);
           // l1.Add("najim"2) //if we added string values in the list like a non genric list that time compiler sould be error
            l1.Add(2);// how to add item 
            l1.Add(3);
            l1.Add(4);

            Console.WriteLine(l1.Count);  //for finding count 
            Console.WriteLine(l1.Capacity); //for finding capacity 

            l1.Add(5);  
            l1.Add(6);
           


            //foreach (int item in l1)
            //{
            //    Console.WriteLine(item); //calling list 
            //}



            ///string type array genric list 
            ///

            List<string> classstudent = new List<string>();
            classstudent.Add("ajay");
            classstudent.Add("rahul");
            classstudent.Add("kishor");
            classstudent.Add("arbaz");

            foreach(string item in classstudent)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
