using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Deligate
{
    class Program
    {
        static void Main(string[] args)
        {
            public delegate bool Predicate<in T>(T obj);

        Predicate<int> d1 = Method1;
        bool b1 = d1(20);
        Console.WriteLine(b1); //

            Predicate<string> d1 = Method2;
        bool b1 = d1("najim");
        Console.WriteLine(b1);
            b1 = d1("zoya");
        Console.WriteLine(b1);

            Action<string, int, string> action = print2;
        action("nsjim", 24, "sakri");

        Func<int, int, int> divi = method1;
        int i = divi(10, 29);
        Console.WriteLine(i);
            Console.ReadLine();
        }

    static int method1(int a, int b)
    {
        return a + b;
    }
    static void print2(string a, int b, string c)
    {
        Console.WriteLine($" string {a} : int {b} : string {c}");
    }

    static bool Method1(int i)
    {
        return i % 2 == 0 ? true : false;
    }
    static bool Method2(string s)
    {
        return s.Length > 2 ? true : false;
    }
}
}