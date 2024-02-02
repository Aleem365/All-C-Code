using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test_short_path
{
    internal class Program
    {

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Row :");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter Colum :");
            int col = int.Parse(Console.ReadLine());
           
            int[,] numArr = new int[row, col];
            int arrRow=numArr.GetLength(0);
            int arrCol=numArr.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter value index on {i},{j}:");
                    int num = int.Parse(Console.ReadLine());
                    numArr[i, j] = num;
                }
            }

            for (int i = 0; i < numArr.GetLength(0); i++)
            {
                for (int j = 0; j < numArr.GetLength(1); j++)
                {
                    Console.Write(numArr[i, j] + ",");
                }
                Console.WriteLine();
            }


            Console.WriteLine("===============================================");
            int rowIndex = 0;
            int colIndex = 0;
            int[] temp;
            for (int i = 0; i < arrRow;   i++)
            {
         
                for(int j = 0; j < arrCol; j++)
                {
                    if ((i < (arrRow - 1)) && (j < (arrCol - 1)))
                    {
                        if ((i == rowIndex) && (j == colIndex))
                        {
                            if (IsPrime(numArr[i, j + 1]) || IsPrime(numArr[i + 1, j]))
                            {

                                if (IsPrime(numArr[i, j + 1]) && IsPrime(numArr[i + 1, j]))
                                {
                                    if (numArr[i, j + 1] < (numArr[i + 1, j]))
                                    {
                                        Console.WriteLine($"{numArr[i, j]} is right nub :{numArr[i, j + 1]}");
                                        rowIndex = i;
                                        colIndex = j + 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{numArr[i, j]} is bottom nub :{numArr[i + 1, j]}");
                                        rowIndex = i + 1;
                                        colIndex = j;
                                    }
                                }
                                else if (IsPrime(numArr[i, j + 1]))
                                {
                                    Console.WriteLine($"{numArr[i, j]} is right nub :{numArr[i, j + 1]}");
                                    rowIndex = i;
                                    colIndex = j + 1;
                                }
                                else
                                {
                                    Console.WriteLine($"{numArr[i, j]} is bottom nub :{numArr[i + 1, j]}");
                                    rowIndex = i + 1;
                                    colIndex = j;
                                }
                            }

                        }
                    }
                        
                }
            }
        }
    }


}

    
