using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Properties._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1._rollnumber = 1;      //assignin / setting /write 
            s1._name = "gaensh";
            s1._passmark = 30;

            //Console.WriteLine($"rollnumber : {s1.Rollnumber} :  name ; {s1.Name} :  passmark  ; {s1.passmark}");
            ////read /get / fetch 

            //Student s2 = new Student();
            //s2.Rollnumber = -1;      //assignin / setting /write 
            //s2.Name = null;
            //s2.passmark = 20;

            //Console.WriteLine($"rollnumber : {s2.Rollnumber} :  name ; {s2.Name} :  passmark  ; {s2.passmark}");
            ////read /get / fetch
            ///
            Student s2 = new Student();
            s2.SetRollnumber(-1);
            s2._name = (null);

            Console.WriteLine($"roll number :  {s2.GetRollnumber()}" + $"name : {s2.GetName()} " );

            Console.ReadLine();
        }
    }
    public class Student 
    {
        public int _rollnumber; 
        public string _name;
        public int _passmark = 30;

        public void SetRollnumber(int rollnumber)
        {
            if (rollnumber > 0)
            {
                _rollnumber = rollnumber;
            }
            else
            {
                _rollnumber = 0;
                Console.WriteLine("Rollnumber cannot be nigative ");
            }
        }
        public int GetRollnumber()
        {
            return _rollnumber;
        }

        public void setname(string name)
        {
            _name = name;

        }
        public string GetName() 
        {
            return !string.IsNullOrEmpty(_name) ? _name : "no name provided ";
           // return //if it is not null or empty  ? that time _name give it as it is   ; otherwise "no name provided ;
            
        }

    }
}
