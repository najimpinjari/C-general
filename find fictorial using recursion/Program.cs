using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_fictorial_using_recursion
{
    class Program
    {
        int num = 5;
        int result = 1;
        
        int factorial()
        {
            if(num == 0)
            {
                return 1 ;
            }
            result = result * num;
            num--;
            factorial();
            return result;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int factorial =  obj.factorial();
            Console.WriteLine(factorial);

            Console.ReadLine();

        }
    }
}
