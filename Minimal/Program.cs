using System;

namespace Minimal
{

    //Тимофеев 
    //Написать метод, возвращающий минимальное из трёх чисел.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c ");
            int c = Convert.ToInt32(Console.ReadLine());
            int min = 0;
            if (a < b && a < c) min = a;
            else if (b < a && b < c) min = b;
            else min = c;
            Console.WriteLine($"{min}");

            

        }
    }
}
