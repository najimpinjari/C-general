using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _5_TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit converstion example //
            
            //intiger veriables 
            int d = 50, r = 50;
            Console.WriteLine(d + r);
            
            //intiger implicitley convert into string 
             string u = d.ToString();
             string v = r.ToString();
             Console.WriteLine(u + v);

            //type casting 'using type cast operators '

            float g1 = 54.51f;
            Console.WriteLine(g1);
            int g2 = (int)g1;
            Console.WriteLine(g2);

            //convert class methods 

            g1 = Convert.ToInt16((int)g2);
            Console.WriteLine(g1);
            //Toint16,32,64

            string t = "1500";
            int j1 = Convert.ToInt32(t);
            Console.WriteLine(j1);


            //parse() and TryParse() methods 

            string o = "77777";
            int k = int.Parse(o); // exicute 
            Console.WriteLine(k);

            string l = "dhwy";
            int x = int.Parse(l); // runtime error
            Console.WriteLine(x);

            string p = "766";
            int q = int.TryParse(p);
            Console.WriteLine(q);

            // Parse()
            // Parse() method throws error when string is not in correct format
            i1 = int.Parse(s); // string -> int
            Console.WriteLine(i1); // 777

            //s = "XYZ";
            //i1 = int.Parse(s); // runtime error
            //Console.WriteLine(i1);

            // TryParse() -> it handles the runtime error
            // convert and return conversion status along with converted value
            // in case of runtime error it returns false, default value as output
            // default value of bool is false
            // default value of int is 0
            // default value of string is null

            h = "2800";
             = int.TryParse(m, out l1);
            Console.WriteLine($"Status : {bbb} Result : {l1}");

            h = "XYZ";
            bbb = int.TryParse(s, out l1);
            Console.WriteLine($"Status : {bbb} Result : {l1}"); // false, 0

            decimal x = 10.52m;
            long l = (long) x; // decimal -> long
            Console.WriteLine(l); // 10

            Console.ReadLine();
        }
    }
}
