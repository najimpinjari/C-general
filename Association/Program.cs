using System;
using System.Collections.Generic;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a School object
            School school = new School("ABC School");

            // Create two Student objects
            Student student1 = new Student("Alice");
            Student student2 = new Student("Bob");

            // Add Students to the School
            school.AddStudent(student1);
            school.AddStudent(student2);

            // Display School's Students
            Console.WriteLine($"Students in {school.Name}:");
            foreach (Student student in school.Students)
            {
                Console.WriteLine(student.Name);

                // Wait for user input before displaying the next student
                Console.ReadKey();
            }
        }
    }

    // Define School class
    class School
    {
        // Properties
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        // Constructor
        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        // Method to add a student to the school
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }

    // Define Student class
    class Student
    {
        // Properties
        public string Name { get; set; }

        // Constructor
        public Student(string name)
        {
            Name = name;
        }
    }
}
