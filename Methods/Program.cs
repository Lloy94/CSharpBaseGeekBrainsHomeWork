using System;

namespace Methods
{
    class Program
    {
        //Тимофеев
        //*  Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause)

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        private static double RMath(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        private static double Imt()
        {
            Console.WriteLine("Введите вес ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост ");
            double h = Convert.ToDouble(Console.ReadLine());
            double i = m / (h * h);
            return i;
        }

        static void Pause()
        {
            Console.ReadKey();
        }

    }
}