using System.Drawing;

namespace ArraySort
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Console.Write("Enter Array size: ");
            int arrLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Array value");
            int[] arr=new int[arrLength];
            int temp=0;
           
            for (int i = 0; i < arrLength; i++) {
                arr[i]=int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <arr.Length; i++)
            {
                
                for(int j  = i+1; j <arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                       
                    }
                }
               
            }
            foreach (int i in arr)
            {
                Console.Write($"{i},");
            }
         }
    }
}