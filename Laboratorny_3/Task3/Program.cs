using System;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t НАЧАЛЬНАЯ МАТРИЦА!!!! \n");
            float max = 0; 
            float [,] myArray = new float [5,10];//Создаем матрицы из 5 строк 10 столбцов
            Random random = new Random();//Создаем обЬект ранндом
        
        
            //Проходимся по матрице 
            for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                            myArray[i, j] = random.Next(100);//Заполняем матрицу
                            Console.Write(myArray[i, j] + "\t");//Выводим матрицу
                        }
                     Console.WriteLine();
                }

            //Проходимся по матрице и вычисляем максимальное значение
            for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                            //Нахождение максимального значения
                           if (max < myArray[i, j])
                           {
                           max = myArray[i, j]; 
                           }

                        }
                }
            
            
            for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                           myArray[i, j] = myArray[i, j]/max;//Деление каждого элемента матрицы на максимальное число
                        }
                }

            Console.WriteLine("\n\n" + "\t\t\t  МАТРИЦА ПОСЛЕ ДЕЛЕНИЯ КАЖДОГО ЭЛЛЕМЕНТА!!!! \n");

            //Проходим по матрице и выводим в консоль
             for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                           
                         Console.Write("{0:0.##} \t",myArray[i, j]);//Выводим матрицу после деления

                        }
                        Console.WriteLine();
                }


        }
    }
}
