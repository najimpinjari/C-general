using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different shapes
            Shape shape1 = new Rectangle(5, 4);
            Shape shape2 = new Circle(3);

            // Display area of each shape
            Console.WriteLine($"Area of shape1: {shape1.CalculateArea()}");
            Console.WriteLine($"Area of shape2: {shape2.CalculateArea()}");
        }
    }

    // Base class: Shape
    class Shape
    {
        // Virtual method: CalculateArea
        public virtual double CalculateArea()
        {
            return 0; // Default implementation for the base class
        }
    }

    // Derived class: Rectangle
    class Rectangle : Shape
    {
        // Fields: Width and Height
        private double width;
        private double height;

        // Constructor
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Override method: CalculateArea
        public override double CalculateArea()
        {
            return width * height;
        }
    }

    // Derived class: Circle
    class Circle : Shape
    {
        // Field: Radius
        private double radius;

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Override method: CalculateArea
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

}
