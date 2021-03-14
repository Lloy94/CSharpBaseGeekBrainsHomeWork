using System;

namespace NumCount
{
    //Тимофеев
    //Написать метод подсчета количества цифр числа.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a ");
            int a = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while (a>0) { a = a / 10; s++; };
            Console.WriteLine($"{s}");

        }
    }
}
