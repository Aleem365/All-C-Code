using System;

namespace AleemArray
{
    class Arrays
    {
        static void Main()
        {
          string[] name = { "aleem", "akram", "waqas", "ali" };

            foreach (string i in name)
            {
                Console.WriteLine(i);
            }

            Object[] mixValue = { "aleem", 34, 31.1, 'F', true };
            foreach(Object i in mixValue)
            {
                Console.WriteLine(i);
            }
          

            
        }
    }
}