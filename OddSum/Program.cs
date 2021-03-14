using System;

namespace OddSum
{
    class Program
    {

        //Тимофеев
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.



        static void Main(string[] args)
        {
            int b = 0;
            int x = 0;
            do
            {
                Console.WriteLine("введите число ");
                b = int.Parse(Console.ReadLine());
                if (b % 2 == 0) x = x + 0;
                else x = x + b;
            }
            while (b != 0);
            Console.WriteLine($"{x}");
           
         
        }
           
    }
}
