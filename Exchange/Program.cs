using System;

namespace Exchange
{
    class Program
    {
        //Тимофеев

        //Написать программу обмена значениями двух переменных:
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной



        static void Main(string[] args)
        {
            Console.WriteLine("Введите a ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b ");
            double b = Convert.ToDouble(Console.ReadLine());
            // double t = a;
            //a = b;
            // b = t;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a} {b}");
        }
    }
}