using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            m1:
            Random random = new Random();
            //Переменные
            Console.Write("Введите количество элеменнтов в массиве : ");
            int N = int.Parse((Console.ReadLine())); //Ввод кол-во элеменнтов в массиве
            Console.Write("Введите число для переменной k : ");
            int k = int.Parse((Console.ReadLine())); //Ввод числа k
            int sum = 0;
            //Определенние исходного массива
            int[] myArray = new int[N];

            for (int i=0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(-15, 15); //Рандомное число

                if (myArray[i] > 0 && myArray[i] % 2 == 0) //Проверка на четность
                {
                    sum += myArray[i]; //Произведение всех четных элементов 
                }              
            }
                
             for (int i = 0; i < myArray.Length; i++)
             {
                 
                {
                 Console.Write(myArray[i] + "\t");
                }
             }

            Console.WriteLine("\n" + "\n\t\t\t ПОЛОЖИТЕЛЬНЫЕ ЧИСЛА ПРИ ДЕЛЕНИЕ НА ПЕРЕМЕННУЮ К С ОСТАТОК 2 \n");
            for (int i = 0; i < myArray.Length; i++)
            {
               if (myArray[i] > 0 && myArray[i] % k == 2) 
               {
                   Console.Write(myArray[i] + "\t");
               }
               
            }

                       
            Console.WriteLine("\n" + "\n Произведение всех четных эллемнтов : " + sum);
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


