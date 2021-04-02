using System;

namespace TableFunc
{
    //Тимофеев
    //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).


    public delegate double Fun(double a,double x);

    class Program
    {
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- A ----- X ----- F -----");
            while (x <= b )
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a,x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double a,double x)
        {
            return a * x * x;
        }

        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            Console.WriteLine("Таблица функции a*x^2:");
            Table(new Fun(MyFunc), -2, -3, 2);
            Console.WriteLine("Таблица функции a*sin(x). ");
            Table(MySin, -2, -3, 2);
            //Console.WriteLine("Таблица функции Sin:");
            //Table(Math.Sin, -2, 2);
            Console.WriteLine("Таблица функции a*x^2:");
            Table(delegate (double a ,double x ) { return a * x * x; },2 ,2 , 6);

        }
    }
}
