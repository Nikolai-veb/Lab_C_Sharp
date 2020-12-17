using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t ДВУХМЕРНЫЙ МАССИВ \n");//Ввывод в консоль заголовка

            int middle = 0;//Среднего арефметического
            int sum = 0;//Сумма всех положительных эллементов
            
            int [,] myArray = new int [5,6];//Создаем матрицы из 5 строк 6 столбцов
            Random random = new Random();//Создаем обЬект ранндом
        
        
            //Проходимся по матрице 
            for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                            myArray[i, j] = random.Next(10, 100);//Заполняем матрицу
                            //Проверяем чтобы елеменнты матрицы были положительными
                            if (myArray[i, j] > 0)
                            {
                                sum += myArray[i, j];//Сумма положительных елементов
                                middle = sum/myArray.GetLength(0);//Среднее арефметическое
                            }
                        }
                }
            //Проходимся по матрице
            for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                            Console.Write(myArray[i, j] + "\t");//Ввыводим в кансоль матрицу
                        }
                        Console.WriteLine();
                }
            Console.WriteLine("\n" +"Среднее арифметическое положительных элементов каждого столбца : " + middle);//Ввыводим в консоль среднее арефметицеско

        }
    }
}
