using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
     public class Program
    {
        public class Person
        {
            // Private field accessible only within the class
            private string _name { get; set; }

            // Public property with private setter, accessible within the class and by derived classes
            public int Age { get; set; }

            // Protected field accessible within the class and by derived classes, but not by other classes
            protected double Height { get; set; }

            // Internal field accessible within the same assembly
            internal int Salary { get; set; }

            // Protected internal field accessible within the same assembly or by derived classes from other assemblies
            protected internal string Address { get; set; }
        }

        static void Main(string[] args)
        {
            // Create an instance of the Person class
            Person person = new Person();

            // Access and manipulate the public members of the Person class
            person.Age = 30; // Setting the Age property (private set within the Person class)
            int age = person.Age; // Getting the value of the Age property

            Console.WriteLine(age);


            // Access the internal field Salary (accessible because it's in the same assembly)
            person.Salary = 50000;

            // Access the protected internal field Address (accessible because it's in the same assembly)
            person.Address = "123 Main St";

            // Since _name is private, we cannot access it directly from outside the Person class
            // person._name = "John"; // This would result in a compile-time error

            // Since Height is protected, we cannot access it directly from outside the Person class
            // person.Height = 6.0; // This would result in a compile-time error


            Console.ReadLine();
        }
    }
}
