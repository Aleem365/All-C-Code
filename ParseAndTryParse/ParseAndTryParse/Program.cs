using System.Linq.Expressions;

namespace ParseAndTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "132";
            int number =Int32.Parse(num);
            bool re = int.TryParse(num, out int result);
            Console.WriteLine(re);
            Console.WriteLine(result.GetType());
            Console.WriteLine(number.ToString().GetType());
        }
    }
}