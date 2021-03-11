using System;

namespace Personal
{
    class Program
    {

        //Тимофеев


        //    а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //    б) *Сделать задание, только вывод организовать в центре экрана.
        //    в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 30);
            Console.WriteLine("Ваше имя ? ");
            var a = Console.ReadLine();
            Console.WriteLine("Ваша фамилия ? ");
            var b = Console.ReadLine();
            Console.WriteLine("Ваш город проживания ? ");
            var c = Console.ReadLine();
            //var x = 40;
            //var y = 15;
            // Console.SetCursorPosition(x, y);
            // Console.WriteLine($"{a} {b} {c}");
            Print($"{a} {b} {c}", 40, 15);

        }
    }
}
