using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace colection_classes_all
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array demos new practice

            //Array 
            //1
            string[] cars = { "bmw", "audi", "sweft", "benz" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            //2
            int[] numbr = { 0, 1, 2, 3, 4 };

            foreach (int num in numbr)
            {
                Console.WriteLine(num);
            }

            //3
            int[] fees = new int[3];// this place diside how many index or item added in the array list
            fees[0] = 1;
            fees[1] = 2;
            fees[2] = 3;
            //fees[3] = 4;  // we cannot add forth item becose array index start with 0 , 0 is first and 1 is second 

            foreach (int num in fees)
            {
                Console.WriteLine(fees);
            }


            Reverse array problem

            int[] number1 = new int[] { 4, 3, 6, 7, 4, 5, 6, 9 };

            Console.WriteLine("original items ");

            for (int i = 0; i < number1.Length; i++)
            {
                Console.Write($" {number1[i]} ");
            }

            find highest number

            int[] number1 = new int[] { 4, 3, 6, 7, 4, 5, 6, 9 };

            int highest = 0;
            for (int i = 0; i < number1.Length; i++)
            {
                for (int j = i + 1; j < number1.Length; j++)
                {
                    if (number1[j] > highest)
                    {
                        highest = number1[j];
                    }
                }
                Console.WriteLine($" highest number is : {highest}");
                Console.ReadLine();

            }

            reverce input string

            Console.WriteLine("please enter your name or string ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ' });

            Console.WriteLine("output : \n");

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($" {words[i]} ");
            }

            #endregion Array demos new practice

            #region Arraylist

            ArrayList roompartenrs = new ArrayList();
            roompartenrs.Add("sham");
            roompartenrs.Add("najim");
            roompartenrs.Add("radhesh");
            roompartenrs.Add("vedant");

            foreach (var i in roompartenrs)
            {
                Console.WriteLine(i);
            }
            //add new item 
            Console.WriteLine("--------------");


            roompartenrs.Add("gotya"); // for adding fantion 
            foreach (var i in roompartenrs)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------");


            roompartenrs.Remove("najim");
            foreach (var i in roompartenrs)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");

            Console.WriteLine(roompartenrs.Capacity); //for capacity 

            Console.WriteLine("--------------");

            roompartenrs.Insert(0, "prathm");
            foreach (var i in roompartenrs)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");





            #endregion Arraylist

            #region hashtable

            Hashtable rooms = new Hashtable();
            rooms.Add(1, "sham");
            rooms.Add(2, "radhesh");
            rooms.Add(3, "najim");
            rooms.Add(4, "gotya ");


            Console.WriteLine(rooms.Count);
            Console.WriteLine(rooms.Values.Count);
            Console.WriteLine(rooms.Keys.Count);
            Console.WriteLine(rooms["najim"]);
            Console.WriteLine(rooms[3]);

            foreach (var room in rooms.Values)
            {
                Console.WriteLine(room);
            }

            foreach (var room in rooms.Keys)
            {
                Console.WriteLine(room);
            }

            Console.WriteLine("----------------------");

            rooms.Remove(1);
            rooms.Remove("sham");
            foreach (var room in rooms.Values)
            {
                Console.WriteLine(room);
            }
            Console.WriteLine("----------------------");

            bool check = rooms.ContainsKey("najim");
            Console.WriteLine(check);

            Console.WriteLine("----------------------");

            bool check1 = rooms.ContainsValue(2);
            Console.WriteLine(check1);
            foreach (var room in rooms.Keys)
            {
                Console.WriteLine(room);
            }
            Console.WriteLine("----------------------");

            Console.WriteLine(rooms["gotya"]);

            rooms.Clear();
            foreach (var room in rooms.Keys)
            {
                Console.WriteLine(room);
            }


            #endregion hashtable

            #region stack 

            Stack myroompartners = new Stack();
            myroompartners.Push("radhesh");
            myroompartners.Push("vedant");
            myroompartners.Push("najim");
            myroompartners.Push("gotya");
            myroompartners.Push("pratham");

            foreach (var item in myroompartners)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");

            myroompartners.Pop();

            foreach (var item in myroompartners)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");


            object topelement = myroompartners.Pop();
            Console.WriteLine(topelement);
            Console.WriteLine("----------------");


            object topelement1 = myroompartners.Peek();
            Console.WriteLine(topelement1);
            Console.WriteLine("----------------");

            int count = myroompartners.Count;
            Console.WriteLine(count);
            Console.WriteLine("----------------");

            bool ckeck = myroompartners.Contains("najim");
            Console.WriteLine(ckeck);

            #endregion stack 

            #region queue

            Queue myroom = new Queue();
            myroom.Enqueue("najim");
            myroom.Enqueue("vedant");
            myroom.Enqueue("radhesh");
            myroom.Enqueue("sham");

            foreach (var item in myroom)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");

            myroom.Dequeue();

            foreach (var item in myroom)
            {
                Console.WriteLine(item);
            }

            object myque = myroom.Peek();
            Console.WriteLine(myque);

            Console.WriteLine("----------------");

            bool check = myroom.Contains("najim");
            Console.WriteLine(check);
            #endregion queue



            Console.ReadLine();

        }
    }
}
