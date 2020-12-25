using System;

namespace Help
{
    class Program
    {
        static void Main(string[] args)
        {
               //Ввод координат
                int N;
                m1:
                Console.WriteLine("Введите координату x для точки M");
                 float x = float.Parse((Console.ReadLine())); // Ввод координаты x

                Console.WriteLine("Введите координату y для точки M");
                float y = float.Parse((Console.ReadLine())); // Ввод координаты y

                //Находим в какой области лежит точка M(x,y)

                if (y > 0)
                {
                    if (x > 0)
                    {
                        if (x > 12) N = 4; else N = 2;
                    }
                    else
                    {
                        if (x < 0)
                        {
                            if (x > -12) N = 4; else N = 1;
                        }
                    }
                }
               else
                {
                    if (x < 0)
                    {
                        if (x > -12) N = 4; else N = 2;
                    }
                    else
                    {
                        if (x > 0)
                        {
                            if (x > 12) N = 4; else N = 3;
                        }
                    }
                }



                //Ввывод результата 
                Console.WriteLine("\t" + "     РЕЗУЛЬТАТ");
                Console.WriteLine( "\n" + "Точка М (" + x + " ; " + y + ") лежит в области N =" + N);
                //Ввывод в консоль
                Console.WriteLine("\n" + "Для продолжения программы нажмите любую клавишу!!!");
                Console.WriteLine("Для завершения программы нажмите Enter.");
                // Создаем переменную для пользовательского ввода
                string p = Console.ReadLine();
                // Проверяем переменную если p = True начинаем программу зново если нет прерываем
                if (p != "")
                goto m1;

        }
    }
}
