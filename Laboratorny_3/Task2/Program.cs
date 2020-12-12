using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t ДВУХМЕРНЫЙ МАССИВ \n");

            int middle = 0;
            int sum = 0;
            int [,] myArray = new int [5,6];
            Random random = new Random();
        
        
        
            for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                            myArray[i, j] = random.Next(10, 100);
                            if (myArray[i, j] > 0)
                            {
                                sum += myArray[i, j];
                                middle = sum/myArray.GetLength(0);
                            }
                        }
                }
            for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                            Console.Write(myArray[i, j] + "\t");
                        }
                        Console.WriteLine();
                }
            Console.WriteLine("\n" +"Среднее арифметическое положительных элементов каждого столбца : " + middle);

        }
    }
}
