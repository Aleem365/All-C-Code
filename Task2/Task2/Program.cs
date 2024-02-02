using System.Runtime.CompilerServices;
using Task2;

namespace Task2
{
    class TaskTwo
    {
        public void ConValue(string conValue)
        {
            switch (conValue)
            {
                case "row":
                    Console.Write("enter arry row:");
                break;
                case "col":
                    Console.Write("enter arry col:");
                    break;
                case "arrEnterValue":
                    Console.WriteLine("Enter Array value");
                    break;
                case "dircation":
                    Console.Write("Plase enter your direction Right for \"w\" and down for \"s\" :");
                    break;
            }
           
        }
         }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
        TaskTwo task2 = new TaskTwo();
            int rowIndex=0;
            int columnIndex=0;
        task2.ConValue("row");
            int rowArr  =int.Parse(Console.ReadLine());
        task2.ConValue("col");
        int colArr =int.Parse(Console.ReadLine());
            string[,] numberArray=new string[rowArr,colArr];
        task2.ConValue("arrEnterValue");
        for (int i = 0; i < rowArr;i++)
            {
                for(int j = 0; j < colArr; j++)
                {
                    numberArray[i, j] = Console.ReadLine();
                }
            }

            

            for (int i = 0;i < numberArray.GetLength(0);i++)
            {
                for (int j = 0;j < numberArray.GetLength(1); j++)
                {
                    Console.Write(numberArray[i,j]+ "\t");
                }
                Console.WriteLine();
            }
            while (true)
            {
                task2.ConValue("dircation");

                Char direction = Convert.ToChar(Console.ReadLine()[0]);
                switch (direction)
                {
                    case 'w':
                        for (int i = 0; i < numberArray.GetLength(0); i++)
                        {
                            for (int j = columnIndex; j < numberArray.GetLength(1); j++)
                            {
                                if ((j != 0))
                                {
                                    Console.Write(numberArray[i, j]);
                                    Console.WriteLine($"  ;;{i}:{j}");
                                    rowIndex = i;
                                    columnIndex = j;
                                    break;
                                }
                            }
                            break;
                        };

                        // Console.WriteLine("this is w right working");
                        break;
                    case 's':
                        for (int i = rowIndex; i < numberArray.GetLength(0); i++)
                        {
                            for (int j = columnIndex; j < numberArray.GetLength(1); j++)
                            {
                           
                                if (i == 1)
                                {
                                    Console.Write(numberArray[i, j]);
                                    Console.WriteLine($"  ;;{i}:{j}");
                                    rowIndex = i;
                                    columnIndex = j;
                                    break;
                                }
                            }
                           
                           
                        };

                        // Console.WriteLine("this is s down working");
                        break;
                    default:
                        Console.WriteLine("you enter wrong Char");
                        break;
                }
            }
            Console.WriteLine($"  ;;{rowIndex}:{columnIndex}");
        }
    }
}