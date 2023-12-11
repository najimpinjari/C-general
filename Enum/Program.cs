using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            //for string output 

            Console.WriteLine("enum name " + NewEnumcClass.thursday);

            //for integer output 
            Console.WriteLine("enum int output : " + (int)NewEnumcClass.friday);
            Console.ReadLine();
        }
    }
}
