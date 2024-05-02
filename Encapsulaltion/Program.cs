using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulaltion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Person object
            Person person = new Person();

            // Set the name and age using the public properties
            person.Name = "Alice";
            person.Age = 30;

            // Display the person's details
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }

    class Person
    {
        // Private fields
        private string name;
        private int age;

        // Public properties to access and modify the private fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                // Ensure age is not negative
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
        }
    }

}
