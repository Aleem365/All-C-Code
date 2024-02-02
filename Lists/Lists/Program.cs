
using System.Reflection;

namespace Lists
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Car car = new Car() { name = "Supra", model = "Mk4", price = 120000 };
            // Car car2 = new Car() { name = "mustang", model = "1998", price = 120000 };
            // Car car3 = new Car() { name = "BMW", model = "M4", price = 120000 };

            // List<Car> cars = new List<Car> { car,car2,car3};


            //cars.Sort();
            // foreach (Car c in cars)
            // {
            //     Console.WriteLine("Car name is {0} and its model is {1} and its onroad price is {2}", c.name, c.model, c.price);
            // }


            List<string> list = new List<string>();
            list.Add("ali");
            list.Add("waqas");
            list.Add("rana");
            list.Add("aleem");
            list.Add(null);
            int[] a= new int[2];
            a[0] = 1;
            a[0] = 2;
            a[1] = 2;
            List<int> b= new List<int> { 1,2,34,6,5,};
            Console.WriteLine(b.Count);
            ;
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort();

            foreach (int item in a)
            {
                Console.WriteLine(item);
            }




        }
    }
    class Car
    {
        public string name { get; set; }
        public string model { get; set; }
        public int price { get; set; }

    }
}