using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //you can insert new student data
            Student s1 = new Student() {
                Rollnumber = 1,
                name = "vishal",
                Gender = "male"
            };

            Student s2 = new Student(10, "vishal", "male");
            s1.Insert();
           

            Console.ReadLine();
        }
    }
    public class Student 
    {
        private int Rollnumber;
        private string name; 
        private string Gender;

        public Student(int rn, string fn , string g)
        {
            Rollnumber=rn;
            name=fn;
            Gender=g;
        }

        public Student()
        {
        }

        private  bool IsValid()
        {
            if  (Rollnumber > 0 && !string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(Gender)) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public void Insert()
        {

            if (IsValid())
            {
                //code to insert data in database 
                Console.WriteLine("new student insert successfully ");
            }
            else 
            {
                Console.WriteLine("invalid data to insert");
            }
          
        }
    }
}
