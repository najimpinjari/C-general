using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRETOR_OVERLODING
{
    public class Student
    {
        public int Rollnumber;
        public string firstname;
        public string lastname;


        public Student(int rn, string fn, string ln)
        {

            Rollnumber = rn; //cunstroctor
            firstname = fn;
            lastname = ln;

        }

       /* public static bool operator == (Student s1, Student s2)
        {
                return s1.Rollnumber == s2.Rollnumber &&
                       s1.firstname == s2.firstname  &&
                       s1.lastname == s2.lastname ;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return s1.Rollnumber != s2.Rollnumber &&
                   s1.firstname != s2.firstname &&
                   s1.lastname != s2.lastname;

        }

*/


    }
    
}   
