using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OPRETOR_OVERLODING
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region int type with == opretors
            /*  int i = 10;
              //int j = i;
              int j = 10;
              if (i== j)
              {
                  Console.WriteLine("i and j are equal ");
              }
              else
              {
                  Console.WriteLine("i and j are not equal");
              }
  */
            #endregion int type 

            #region string type with == opretoers 

         /*   string i = "rupesh";
            // string j = i;
            string j = "rupesh";    
            if (i == j)
            {
                Console.WriteLine("i and j are equal ");
            }
            else
            {
                Console.WriteLine("i and j are not equal");
            }

*/




            #endregion string typw with == opereors 

            Student s1 = new Student (1,"rupesh" , "nilesh");
            // Student s2 = s1;
            Student s2 = new Student(1, "rupesh", "nilesh");

           // if (s1 ==s2) 
           if (s1.Rollnumber == s2.Rollnumber &&
                s1.firstname == s2.firstname &&
                s1.lastname == s2.lastname )
            {
                Console.WriteLine("s1 and s2 are equal ");
            }
            else
            {
                Console.WriteLine("s2 and s1 are not equal");
            }






            Console.ReadLine();

        }
    }
}
