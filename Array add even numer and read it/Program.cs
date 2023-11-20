using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_add_even_numer_and_read_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Eneter the target number ");
            int target = int.Parse(Console.ReadLine());

            int evencount = target / 2;
            int[] evens = new int[evencount];
            int counter = 2;
                
            for(int i = 0; i < evencount; i++ , counter+=2)
            {
                evens[i] = counter;
            }
            for (int i = 0; i < evens.Length; i++)
            {
                Console.Write($"{evens[i]} ");
            }]]]]]]]]]]f
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
