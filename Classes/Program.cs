namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Calcul obj = new Calcul();
            obj.firstnumber = 20;
            obj.secondnumber =5;
            obj.sum();
            obj.sub();
            obj.mul();
            obj.div();
        }
    }
    class Calcul
    {
       public int firstnumber;
       public  int secondnumber;
       public void sum( )
        {
            Console.WriteLine( "Sum of two number : " , firstnumber + secondnumber);
            Console.ReadLine();
        }
        public void sub( )
        {
            Console.WriteLine("Subtract of two number : ", firstnumber - secondnumber);
                Console.ReadLine();
        }
        public void mul( )
        {
            Console.WriteLine("Multiply of two number : ", firstnumber * secondnumber);
            Console.ReadLine();
        }
        public void div( )
        {
            Console.WriteLine("Divide of two number : ", firstnumber / secondnumber);
            Console.ReadLine();
        }

         
    }
}