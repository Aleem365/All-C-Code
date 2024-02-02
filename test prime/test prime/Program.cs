namespace test_prime
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Prime numbers between first:");
            int f =int.Parse(Console.ReadLine());
            Console.Write("Prime numbers between second:");
            int s = int.Parse(Console.ReadLine());


            for (int i = f; i <= s; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}