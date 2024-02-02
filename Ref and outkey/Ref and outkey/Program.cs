namespace Ref_and_outkey
{
    internal class Program
    {

        //// This method of OUT Keyword
        //public static void passByOut(out int a)
        //{
        //    a =  50;

        //    Console.WriteLine(a);

        //}

        // this is Ref Keyword method 
        public static void passByRef(ref int a)
        {
            
            a += 30;
            Console.WriteLine(a);
        }

        //this is method by pass value
        //public static void passbyvalue(int a)
        //{
        //    a += 10;
        //    Console.WriteLine(a);
        //}
        static void Main(string[] args)
        {
            int value=10;
            //passbyvalue(value);      // pass by value method call

            passByRef(ref value); // this Ref method Call

            //passByOut(out value);

            Console.WriteLine(value);



        }
    }
}