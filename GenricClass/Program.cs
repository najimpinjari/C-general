using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricClass
{   public class MainClass
    { 
        private static void Main()
        {
            bool Equal = Calculater.AreEqual<string>("aaaa", "aaa");

            if( Equal )
            {
                Console.WriteLine("Equal");
            }
            else 
            {
                Console.WriteLine("Not Equal");

                Console.ReadLine();

            }

        }

    }
    public  class Calculater
    {
        public static bool AreEqual<T>(T value1 , T value2)
        {
            return value1.Equals(value2 );

        }

    }

}
