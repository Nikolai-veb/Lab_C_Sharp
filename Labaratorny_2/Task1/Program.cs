using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод переменных с консоли

            float f_min;
            float f_max;
    
            m1:

            Console.WriteLine("Введите значение X"); //Вывод в консоль
            float x = float.Parse((Console.ReadLine())); // Считывает ввод с консоли и преобразует в тип float

            Console.WriteLine("Введите значение Y"); //Вывод в консоль
            float y = float.Parse((Console.ReadLine())); // Считывает ввод с консоли и преобразует в тип float
            
            Console.WriteLine("Введите значение Z"); //Вывод в консоль
            float z = float.Parse((Console.ReadLine())); // Считывает ввод с консоли и преобразует в тип float

            //Находим максимальное значение из x, z          
            if (x > z)
            {
                 f_max = x;
            } 
            else
            {
                 f_max = z;
            }
            
            //Находим минимальное значение из x, y, z 
            if (x < y)
            {
                if (x < z) f_min = x; else f_min = z;
            } 
            else
            {
                if (y < z) f_min = y; else f_min = z;
            }

            //Вычмсление значения функцыи

            float f = (f_min + x) / (f_max * f_max + y);
            
            //Выводим в косоль

            Console.WriteLine(
                "\n" + "Дано : X = " + x + "\t" + "Y = " + y + "\t" + "Z = " + z + "\n" + "Результат F = " + f
                );
            
            Console.WriteLine("Для продолжения программы нажмите любую клавишу!!!");
            Console.WriteLine("Для завершения программы нажмите Enter.");
             // Создаем переменную для пользовательского ввода
            string p = Console.ReadLine();
            // Проверяем переменную если p = True начинаем программу зново если нет прерываем
            if (p != "") 
                goto m1;
        }
    }
}