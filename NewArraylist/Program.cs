using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraylistNew
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            ////make a array 

            //int[] numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion Array

            //Make a Arraylist

            //Console.BackgroundColor = ConsoleColor.Magenta;
            //Console.ForegroundColor = ConsoleColor.Yellow;

            ArrayList numbers = new ArrayList(4);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(10);

            Console.WriteLine("original collection");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]}  ");
            }
            Console.WriteLine();

            //foreach (int i in numbers)
            //{   
            //    Console.Write(numbers[i]);
            //}

            //Add multiple items

            ICollection coll = new ArrayList() { 40, 41, 42, 43, 44 };
            numbers.AddRange(coll);

            Console.WriteLine(" addrange(call) callection ");

            for (int i = 0; i < numbers.Count; ++i)
            {
                Console.Write($" {numbers[i]}  ");
            }
            Console.WriteLine();
            //2   3   4   10   40   41   42   43   44

            //numbers.Add(19);  
            numbers.Insert(1, 1);

            Console.WriteLine(" add( 1) ");

            for(int i = 0; i < numbers.Count; i++)
            {
                Console.Write( $" { numbers[i]} "  );
            }
            Console.WriteLine();

            ICollection call = new ArrayList() { 11, 12, 13, 14, 15, 16, 17, 18, };
            numbers.InsertRange(0, call);

            Console.WriteLine(" add( { 11, 12, 13, 14, 15, 16, 17, 18, };) ");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($" {numbers[i]} ");
            }
            Console.WriteLine();

           bool b1 =  numbers.Contains(11);
            Console.WriteLine(b1);

            bool b2 = numbers.Contains(99);
            Console.WriteLine(b2);

            numbers.Remove(11);
            numbers.RemoveAt(0);

            Console.WriteLine(" add(  numbers.Remove(11);   numbers.RemoveAt(0); ");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($" {numbers[i]} ");
            }





            Console.ReadLine();
        }


    }
}
