using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Yield_demo
{
    class Program
    {
        static List<string> cars = new List<string>();

        public static void Main(string[] args)
        {

            //add five cars 
            cars.Add("bmw");
            cars.Add("audi");
            cars.Add("benz");
            cars.Add("swift");
            cars.Add("ferari");
            cars.Add("gwagon");

            //for display result

            foreach (string car in Filters())
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();

        }
        public static IEnumerable<string> Filters()
        {
            //List<string> temp = new List<string>();
            foreach (var car in cars)
            {
                if (car.StartsWith("b")) ;
                {
                    yield return car;
                }

            }
            //return temp;
        }
    }
}
