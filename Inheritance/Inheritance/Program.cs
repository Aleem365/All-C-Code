namespace Inheritance
{
    class DrivedClass1 : BaseClass
    {
       
        public void show1()
        {
            Console.WriteLine("This is the method of 1st drive (Child) Class");
        }
    }
    class DrivedClass2: DrivedClass1
    {
       public void show2()
        {
            Console.WriteLine("This is the method of 2nd drive (Child) Class");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
           //BaseClass par= new BaseClass();
           // par.show();
           DrivedClass1 ch1 = new DrivedClass1();
           ch1.show();

            DrivedClass2 ch2 = new DrivedClass2();
            ch2.show2();    
            ch2.show();
            ch2.show1();

        }
    }
}