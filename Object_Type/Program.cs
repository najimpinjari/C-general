using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int i = 10;
            //bool b = true;
            //string s = "rupesh";
            //Student s1 = new Student();

            //object i = 10;
            //object b = true;
            //object s = "rupesh";
            //object s1 = new Student();

            //int i = 10;
            ////Type i1 = typeof(int);
            //Type i1 = i.GetType();
            //Console.WriteLine($"{i1.Namespace} ; {i1.Name} ; {i1.FullName}");

            //bool b = true;
            ////Type i1 = typeof(int);
            // i1 = b.GetType();
            //Console.WriteLine($"{i1.Namespace} ; {i1.Name} ; {i1.FullName}");

            //string s = "jayesh";
            ////Type i1 = typeof(int);
            // i1 = s.GetType();
            //Console.WriteLine($"{i1.Namespace} ; {i1.Name} ; {i1.FullName}");

            //Student s1  = new Student();
            //i1 = s1.GetType();
            //Console.WriteLine($"{i1.Namespace} ; {i1.Name} ; {i1.FullName}");



            int i = 10, j = 10;
            Console.WriteLine(i + j);
            Console.WriteLine(i.ToString() + j.ToString());

            double d = 10.4;
            Console.WriteLine(d.ToString());

            Student s1 = new Student()
            { FirstName = "ganesh" , LastName = "pawar"};
            Console.WriteLine(s1.ToString());


            #endregion to string 




            Console.ReadLine();
        }
    }
    public class Student
    {
        public string FirstName;
        public string LastName;
    }
}
