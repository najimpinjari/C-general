using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("najim");

            sb.AppendLine("pinjari");

            string result = sb.ToString();
            Console.WriteLine(result); 

            Console.ReadLine();

        }
    }
}
