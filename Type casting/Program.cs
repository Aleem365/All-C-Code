using System;

namespace AleemWorks
{
    class typeCsting
    {
        static void Main(string[] args)
        {
            // implicit Casting
            int number = 20;
            double convertNumber = number;
            Console.WriteLine(convertNumber);

            // Explicit Casting
            double myNumber = 23.23; 
            // first method for explicit casting
            int myIntNum = (int)myNumber;
            Console.WriteLine(myIntNum);
            // second method 
            int myInt = 38;
            double myDouble = 12.43;
            bool myBool = false;
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Convert.ToBoolean(myInt));
        }
    }
}