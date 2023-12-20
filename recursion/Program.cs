using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        int num = 1; // Recursion is the proces by virtual of which of method can call itself 
        void counting()
        {
            Console.WriteLine(num);
            num++;
            counting();
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.counting();

            Console.ReadLine();


        }
    }
}
