using System.Runtime.ExceptionServices;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (firstNumber < 0 || secondNumber < 0)
            {
                Console.WriteLine("Please Correct type pattern");
            }
            else
            {
                if (firstNumber > secondNumber )
                {
                    for (int i = secondNumber; i <= firstNumber; i++)
                    {
                        if (i % 3 == 0 || i % 5 == 0)
                        {
                            sum += i;
                        }
                    }
                }
                else
                {
                    for (int i = firstNumber; i <= secondNumber; i++)
                    {
                        if (i % 3 == 0 || i % 5 == 0)
                        {
                            sum += i;
                        }
                    }
                }

            }



            Console.WriteLine($"The Total number of sum:{sum}");
        }
    }
}