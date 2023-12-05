using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{

    class Account
    {
         int accountbalance = 1000; //variable who can store a data accountbalance = 1000
        //access modifier // datatype // datastore 
        //public void Setbalance(int amount) //paramiter 
        //{
        //    if (accountbalance >0) 
        //    {
        //        Console.WriteLine("you cannot add nigative values");
        //    }
        //    else
        //    {
        //        accountbalance = amount;// any amount record in paramiter assing to the accountbalance paramiter 

        //    }
        //}
        //public void Getbalance()
        //{
        //    Console.WriteLine("your account balance is " + accountbalance);// for values gate getbalacne method 
        //}
        public int balance
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("you cannot add nigative values ");
                }
                else
                {
                    accountbalance = value;
                }
            }
            get
            {
                return accountbalance;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Account Myaacount = new Account();  //we want to accsec the account class 
            //we make abject of account class 
            //
            Myaacount.balance = 100000; //we helps with seter method acount balance(priyet variable ) we can modify or change or pudate 
            //Myaacount.Getbalance(); //calling get metod 
            Console.WriteLine("your account balance is "+Myaacount.balance);

            
            Console.ReadLine();// for exicution pose 
        }
    }
}
