using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constractors
{
    public class Student1
    {
        public int Rollnumber;
        public string FirstName;
        public string LastName;
        public string coursename = "dotnet";

        public void Details()
        {
            Console.WriteLine($"Rollnumber ; {Rollnumber} fullName ;{FirstName} {LastName} {coursename}");
          
        }

        public Student1()
        {
            Console.WriteLine("Public  Student() Constructor Called ");
            Rollnumber = 3;
            FirstName = "rupesh";
            LastName = "pawar";
           coursename = "dot.net";
        }



        public void initialize ( int rn, string fn , string ln)
        {
            Rollnumber = rn;
            FirstName = fn;
            LastName = ln;
        }
        //paameterize constructor 
        public Student1(int rn , string fn , string ln)
        {
            Console.WriteLine("Student1(int rn , string fn , string ln) Constructor called ");
            Rollnumber = rn;
            FirstName = fn;
            LastName = ln;
        }

        //copy constructor 
        public Student1(Student1 s)
        {
            this.Rollnumber = s.Rollnumber;
            this.FirstName = s.FirstName;
            this.LastName = s.LastName;
        }

        //static constructor    
        static Student1()
        {
            Console.WriteLine("Public  Student() Constructor Called ");
        }
    }
}
