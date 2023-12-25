using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_demo
{
    class Animal
    {
        public string Name { get; set; }

        // Constructor
        public Animal(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }

    // Child class 1
    class Dog : Animal
    {
        // Constructor
        public Dog(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says Woof!");
        }

        public void WagTail()
        {
            Console.WriteLine($"{Name} is wagging its tail.");
        }
    }

    // Child class 2
    class Cat : Animal
    {
        // Constructor
        public Cat(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says Meow!");
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} is purring.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating instances of the classes
            Dog dog = new Dog("Buddy");
            Cat cat = new Cat("Whiskers");

            // Using the methods of each instance
            dog.Eat();
            dog.Speak();
            dog.WagTail();

            cat.Eat();
            cat.Speak();
            cat.Purr();
        }
    }
}