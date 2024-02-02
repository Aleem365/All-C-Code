using System;
using System.Globalization;


namespace Access_Modifiers
{
    class Vehical
    {
        string name;
        string model;
        string color;
        int price;
        public void show1()
        {
       
            
            Console.WriteLine("Please enter an intern name");

        }
        //protected void show2()
        //{
        //    show1();

        //}
    }

    internal class Program : Vehical
    {

         string name;
        static void Main(string[] args)
        {

            //Vehical veh = new Vehical();
            Program p = new Program();
            p.show1();
            //    p.name = "Aleem";
            //    Console.WriteLine(p.name);
            // p.show2();
            //veh.show2();
        }
    }
}