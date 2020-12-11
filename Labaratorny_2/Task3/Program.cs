using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            float f_max;
            float f_min;
            m2:
            //Ввод вещественных чисел
           Console.WriteLine("Введите первое значение");
           float x = float.Parse((Console.ReadLine())); // Ввод значения x
           
           Console.WriteLine("Введите второе значение");
           float y = float.Parse((Console.ReadLine())); // Ввод значения y

           //Находим максимальное значение
           if (x > y) f_max = x; else f_max = y;
           
           //Находим минимально значение
           if (x < y) f_min = x; else f_min = y;

             //Ввывод результата 
            Console.WriteLine("\t" + "     РЕЗУЛЬТАТ");
            Console.WriteLine("\n" + "Превое значение : " + x + "\n" + "Второе значение :" + y);
            Console.WriteLine( "\n" + "Максимальное значение :" + f_max + "\n" + "Минимальное значение " + f_min);
            //Ввывод в консоль
            Console.WriteLine("\n" + "Для продолжения программы нажмите любую клавишу!!!");
            Console.WriteLine("Для завершения программы нажмите Enter.");
             // Создаем переменную для пользовательского ввода
            string p = Console.ReadLine();
            // Проверяем переменную если p = True начинаем программу зново если нет прерываем
            if (p != "") 
                goto m2;
        }
    }
}
