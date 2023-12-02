using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ObjType
{
    public class Program
    {
        static void Main(string[] args)
        {

            //string name = "rupesh raut";
            //Type type = name.GetType();
            //Console.WriteLine($"Type of name :" + type.Name);

            //int i = 10;
            //int j = 110;

            //if (i.Equals(j)) 
            //{
            //    Console.WriteLine("i and j are equals");
            //}
            //else
            //{
            //    Console.WriteLine("i and j is not equals ");
            //}
            //Student s1 = new Student()
            //{ Firstname = "rupesh", Lastname = "pawar" };
            //Student s2 = new Student()
            //{ Firstname = "ganesh", Lastname = "patil" };


            //if (s1.Equals(s2))
            //{
            //    Console.WriteLine("s1 and s2 are equals");
            //}
            //else
            //{
            //    Console.WriteLine("s1 and s2 are not equals ");
            //}

            //int i = 19;
            //int j = 20;
            Student i = new Student() { Firstname = "jayesh", Lastname = "pawar" };
            Student j = new Student() { Firstname = "kamlesh", Lastname = "nikam" };

            string result = (i == j) ? "Equals " : "NOT Equals";
            Console.WriteLine(result);

            result =  (i.Equals( j)) ? "Equals " : "NOT Equals";
            Console.WriteLine(result);

             result = (i.GetHashCode() == j.GetHashCode()) ? "Equals " : "NOT Equals";
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
    public class Student
    {
       public  string Firstname;
        public string Lastname;
    }
}
