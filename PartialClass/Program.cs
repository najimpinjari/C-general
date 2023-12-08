
using System;

namespace PartialClass
{
    public partial class Employee
    {
        public void EmployeeName()
        {
            Console.WriteLine("Emp name Rupesh Raut ");
        }
    }

    public partial class Employee
    {
        public void EmployeeDep()
        {
            Console.WriteLine("IT department ");
        }
    }

    public partial class Employee
    {
        public void EmployeeSalary()
        {
            Console.WriteLine("100000 ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeName();
            emp.EmployeeDep();
            emp.EmployeeSalary();
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PartialClass
//{
//    public partial class Employee
//    {
//        public void EmployeeName()
//        {
//            Console.WriteLine("Emp name Rupesh Raut ");
//        }

//    }
//    public partial class Employee
//    {
//        public void EmployeeDep()
//        {
//            Console.WriteLine("IT department ");


//        }

//    }
//    public partial class Employee
//    {
//        public void EmployeeSalary()
//        {
//            Console.WriteLine("100000 ");

//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee emp = new Employee();
//            emp.EmployeeName();
//            emp.EmployeeDep();
//            emp.EmployeeSalary();


//        }
//    }
//}
