namespace Generic
{
    internal class Program
    {

        // generic method
        public static bool Cal<T>(T a, T b)
        {

            return a.Equals(b);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Cal<Object>("ali", "ali"));
            Example<int> p = new Example<int>(20);
            Console.WriteLine(p.showName());
        }

        class Example <T>
        {
           public Example(T name)
            {
                this.name=name;
            }
            T name;

            public T showName()
            {
                return name;

            }
        }
    }
}

