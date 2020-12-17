using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод в консоль
            Console.WriteLine("Дан радиус(R) окружности. Найти длину окружности(C) и площадь круга(S)");
            Console.WriteLine(" Введите радиус окружноси: ");

            string z = Console.ReadLine();//Считывает ввод с клавиатуры
            double r = Convert.ToDouble(z);//Конвертирования данных
            double p = 3.1415926;//Число p

            //Длина окружности
            double c = 2 * p * r;
            
            //Площадь окружности
            double s = p * r * r;
            //Вывод в консоль
            Console.WriteLine("R = {0} \n C = {1} \n S = {2}", z, c, s);
        }
    }
}
