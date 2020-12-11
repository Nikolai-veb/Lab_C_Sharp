using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Расчет функции
            Console.WriteLine("Введите значение x"); //Выводим в консоль

            string y = Console.ReadLine() ;  double p = 3.141559; //Создаем переменные

            double x = Convert.ToDouble(y); //Конвертируем тип данных переменной

            double b = Math.Pow((x + 7/6), 4/3) + Math.Sin(x) + Math.Asin(Math.Cos(x * p)); //Записываем в переменную функцыю

            //Вывод в консоле
            Console.WriteLine("Расчет функции");
            Console.WriteLine(" B = (x + 7/6)7/3 + sin*x + arcsin(cos px) ");
            Console.WriteLine(" x = {0} \n B = {1} ", y, b);
            Console.ReadKey();
        }
    }
}
