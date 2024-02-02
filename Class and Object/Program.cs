using System;
namespace Class_and_Object
{
    public delegate string explain(string name,string modal,int price);
     class Program
    {

        static void Main(string[] args)
        {
            //   Console.WriteLine("Hello, World!");
            //Phone p = new Phone("Redme","Node 9s",);
            // Console.WriteLine(p.deatail());
            // explain p= new explain (Phone.deatail);
            // Console.WriteLine(p("redme","Node 9s",2500)) ;
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i * i;
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }
    }
    public class Phone
    {
        public Phone(string name,string modal,int price) { 
            this.name = name;
            this.modal = modal;
            this.price = price;
        }

        string name;
        string modal;
        int price;
        public static string deatail(string name,string modal,int price) {
            string deatails = $"my phone name is {name} and model is {modal} and it\'s price {price}";
            return deatails;
        }
    }
}