using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Child class
            Child child = new Child();

            // Call methods from both Parent and Child classes
            child.DisplayParentMessage();
            child.DisplayChildMessage();
        }
    }

    // Parent class
    class Parent
    {
        public void DisplayParentMessage()
        {
            Console.WriteLine("This is a message from the Parent class.");
        }
    }

    // Child class inherits from Parent class
    class Child : Parent
    {
        public void DisplayChildMessage()
        {
            Console.WriteLine("This is a message from the Child class.");
        }
    }

}
