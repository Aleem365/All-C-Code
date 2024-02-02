using System;

namespace AleemMethod {
    class Methods
    {
  static string myMethod(string fname, int age = 20)
        {
            string myName = ($"My name is {fname} and my age is {age}");
            return myName;
        }

        static int myPlus(int a,int b)
        {
            return a + b;
        }

        static double myPlus(double a,double b)
        {
            return a + b;
        }

     static void Main()
        {
            int Method1 = myPlus(12, 32);
            double Method2 = myPlus(12.2, 45.5);
            Console.WriteLine("Int" + Method1);
            Console.WriteLine("double" + Method2);
        }
    }
}