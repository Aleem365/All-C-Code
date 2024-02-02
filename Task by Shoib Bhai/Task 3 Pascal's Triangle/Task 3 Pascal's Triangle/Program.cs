namespace Task_3_Pascal_s_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Size of pascal's triangle :");
            int row=int.Parse(Console.ReadLine());
            int store = 1;
            for(int i = 0; i < row; i++)
            {
              

                for (int j = 0; j <=i; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        store = 1;

                    }
                    else
                    {
                        store = store * (i - j + 1) / j;
                    }
                        Console.Write(store + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}