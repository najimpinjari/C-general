using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_in
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target number ; ");
            int target = int.Parse(Console.ReadLine());

            for(int i = 0; i < target; i++)
            {
                if (i % 2 == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine(); // new line 


            Console.ReadLine();
        }
    }
}
