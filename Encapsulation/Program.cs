using System;
using System.Runtime.CompilerServices;

namespace Encapsulation
{
    internal class Program
    {
        // encapsulation first method set and get method ;

        class Person
        {
            string name;
            int age;
            public void setValue(string name, int age)
            {
                if ((string.IsNullOrEmpty(name) == true) && (age < 0))
                {
                    Console.WriteLine("Plz try again");
                }
                else
                {
                    this.name = name;
                    this.age = age;
                }

            }
            public void getValue()
            {
                Console.WriteLine($"My name is {name} and my age is {age} years");
            }

        }

        // second concept is perproties

        //class Account
        //{
        //    int cash;

        //    public int Balance
        //    {
        //        set
        //        {
        //            if (value < 0)
        //            {
        //                Console.WriteLine("Please dont enter negative value");
        //            }
        //            else
        //            {
        //           this.cash = value;
        //            }
        //        }
        //        get
        //        {
        //            if (cash < 0)
        //            {
        //                Console.WriteLine("Your balance limit is creak");
        //            }
        //            else
        //            {
        //            return this.cash;
        //            }
        //            return 0;
        //        }

        //    }
        //}

        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Enter Your  Name :");
            string naam = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            int ages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ages);
            p.setValue("", -10);
            p.getValue();


            //Account acc = new Account();
            //Console.WriteLine("Enter your cash value :");
            //acc.Balance = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your accont balance  is :" + acc.Balance);

        }
    }
}