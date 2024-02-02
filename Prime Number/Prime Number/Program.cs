using System.Collections.Specialized;

namespace Prime_Number
{
    internal class Program
    {
        public static void checkPrime(int firstNumber, int secondNumber) {
            int a = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                a = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("enter first number :");
            int firstnumber = int.Parse(Console.ReadLine());
           Console.Write("enter second number :");
            int secondnumber = int.Parse(Console.ReadLine());
            checkPrime(firstnumber, secondnumber);         
            


        }
    }
}