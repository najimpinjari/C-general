using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const_and_readonly
{
    public class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.Rollnumber = 1;
            s1.Name = "zoya";
            //s1.companyname = "Piramal";

            Console.WriteLine($" Rollnumber : {s1.Rollnumber} name : {s1.Name} company name ; {s1.companyname}");

          //  student.companyname = "aditya birla";


            student s2 = new student();
            s2.Rollnumber = 2;
            s2.Name = "shifa";
           // s2.companyname = "HDFC";

            Console.WriteLine($" Rollnumber : {s2.Rollnumber} name : {s2.Name} company name ; {s1.companyname}");


            Console.ReadLine();
        }

    }
    public class student
    {
        public int Rollnumber { get; set; }
        public string Name { get; set; }

        //public static string companyname = "Axix bank";
        //public const string companyname = "Axix bank"; // this is a const keyword you can only onec fix the obj 

        public readonly string companyname;

        public student()
        {
            //runtime 
            companyname = "bajaj";
        }

    }
}
