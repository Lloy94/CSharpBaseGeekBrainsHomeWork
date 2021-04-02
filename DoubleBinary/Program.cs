using System;
using System.Collections.Generic;
using System.IO;

namespace DoubleBinary
{

    //Тимофеев
    //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
    //б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out). 

    class Program
    {
        public delegate double Function(double x);
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F2(double x)
        {
            return x * x * x;
        }

        public static double F3(double x)
        {
            return Math.Sin(x);
        }

        public static double F4(double x)
        {
            return Math.Cos(x);
        }


        public static void SaveFunc(Function F, string fileName, double min, double max, double h)
        {
            FileStream fs = new(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new(fs);
            double x = min;
            while (x <= max)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double [] Load(string fileName, out double min)
        {
            FileStream fs = new(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new(fs);
            double[] arr = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                arr[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return arr;
        }
        static void Main(string[] args)
        {
            List<Function> functions = new() { F1, F2, F3, F4 };
            Console.WriteLine("Введите номер функции");
            Console.WriteLine("1) f(x)=x * x - 50 * x + 10");
            Console.WriteLine("2) f(x)=x^3");
            Console.WriteLine("3) f(x)=Sin(x)");
            Console.WriteLine("4) f(x)=Cos(x)");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начало отрезка");
            double min = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка");
            double max = double.Parse(Console.ReadLine());
            SaveFunc(functions[choice-1], "data.bin", min, max, 0.5);
            Console.WriteLine(Load("data.bin",out min));
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
