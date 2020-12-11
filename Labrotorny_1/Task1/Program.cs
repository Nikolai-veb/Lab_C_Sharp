using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывести версию операционной системы
            OperatingSystem os = System.Environment.OSVersion;

            Console.WriteLine("Platform: {0}", os.Platform);
            // Текущая дата и время
            System.Console.WriteLine("The current date and time is " + System.DateTime.Now);
            Console.ReadKey();
        }
    }
}
