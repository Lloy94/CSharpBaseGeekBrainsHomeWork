using System;

namespace Recursive
{
    class Program
    {
        //Тимофеев
        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

        static void Loop(int a, int b, int c)
        {

            if (a <= b) Loop(a + 1, b, c + a);
            else Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("введите a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите b ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            if (a > b) Console.WriteLine(" а больше b, введите другие числа");
            else Loop(a, b,c);
            //Loop(a, b);
            


        }

        //static void Loop(int a, int b)
        //{
        //    Console.WriteLine( a);
        //    if (a < b) Loop(a + 1, b);
        //}




    }
}

