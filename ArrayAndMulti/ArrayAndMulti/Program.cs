namespace ArrayAndMulti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array3D = new int[,,] {
                { { 1, 2, 3 }, { 4,   5,  6 } },
                { { 7, 8, 9 }, { 10, 11, 12 } } };

            int[,] num = {{ 1, 2, 3, 9 },{ 1,2,3,34} };
            string a = "*";
            for (int i = 0;i<2;i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }

        }
    }
}