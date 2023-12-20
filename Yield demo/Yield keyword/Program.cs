using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_keyword
{
    class Program //yeald keyword 
    {   
        static IEnumerable<int> yeild1()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }


        static void Main(string[] args)
        {
            foreach (int i in yeild1())
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
