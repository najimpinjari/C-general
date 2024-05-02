using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    // Abstract class: Vehicle
    abstract class Vehicle
    {
        // Abstract method: Start
        public abstract void Start();

        // Abstract method: Stop
        public abstract void Stop();
    }

    // Concrete class: Car
    class Car : Vehicle
    {
        // Implementation of Start method
        public override void Start()
        {
            Console.WriteLine("Car is starting...");
        }

        // Implementation of Stop method
        public override void Stop()
        {
            Console.WriteLine("Car is stopping...");
        }
    }

    // Concrete class: Motorcycle
    class Motorcycle : Vehicle
    {
        // Implementation of Start method
        public override void Start()
        {
            Console.WriteLine("Motorcycle is starting...");
        }

        // Implementation of Stop method
        public override void Stop()
        {
            Console.WriteLine("Motorcycle is stopping...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Motorcycle
            Vehicle car = new Car();
            Vehicle motorcycle = new Motorcycle();

            // Call Start and Stop methods for both vehicles
            car.Start();
            car.Stop();

            motorcycle.Start();
            motorcycle.Stop();
        }
    }

}
