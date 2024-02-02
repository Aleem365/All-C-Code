using System;
using System.Transactions;

namespace start_fundamentel
{
    internal class Program
    {

        public

        static void Main(string[] args)
        {
            void show(int number)
            {
                int[] num = { 0, 5, 15 };
                Console.WriteLine(num[number]);
            }

            int a = Convert.ToInt32(Console.ReadLine());
            show(a);
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(2, 3)); // Output: 5
        }
      
        string lists = " enter number";
        string p1 = "player 1";
        string p2 = "player 2";
        Console.WriteLine($"{p1} {lists}");
            Console.WriteLine("Press 1 to perform action 1");
            char key = Console.ReadKey().KeyChar;
            Console.WriteLine(key);
        }

    }
