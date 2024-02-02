namespace Calculator
{
    class Calculator
    {
        public double firstNumber;
        public double secondNumber;
        public Char opartor;
        public double Calcul( double firstNumber, double secondNumber)
        {
            return firstNumber ;
        } 
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
          Calculator cal = new Calculator();
            Console.Write("Enter First Number:");
            cal.firstNumber= Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Only operator:");
            cal.opartor = Console.ReadLine()[0];
            Console.Write("\nEnter second number:");
            cal.secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nfirst:{cal.firstNumber} second{cal.secondNumber} and operator:{cal.opartor}");
           
        }
    }
}