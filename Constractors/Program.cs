using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constractors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student1 s1 = new Student1();
            s1.Details();

            //fist way to initialization object 

            Student1 s2 = new Student1();
            s2.Rollnumber = 20;
            s2.FirstName = "Abhisek";
            s2.LastName = "sutar";
            s2.Details();

            //second way to initialization object 

            Student1 s3 = new Student1()
            {
                Rollnumber = 22,
                FirstName = "Abhisek",
                LastName = "sutar"
            }; 
            s3.Details();

            Student1 s4 = new Student1();
            s4.initialize(12,"arbaz" , "mujjavar");
            s4.Details();

            Student1 s5 = new Student1(11,"vivek" , "pawar");
            s5.Details();

            Student1 s6 = s5;
            s6.Details();

            Student1 s7 = new Student1(s4);
              s7.Details();
            /*
                        Student1 s8 = new Student1();
                        s8.Details();
                        Student1 s9 = new Student1();  
                        s9.Details();
                        Student1 s10 = new Student1();
                        s10.Details();
            */
            //Student1 s11 = new Student1();
            //Student1 s12 = new Student1();



            Console.ReadLine(); 
        }
    }
}
