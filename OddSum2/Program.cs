﻿using System;

namespace OddSum2
{

    //Тимофеев
   //а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
  // б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
    class Program
    {
        static void Main(string[] args)
        {
            int b ;
            int x = 0;
            do
            {
                while (true)
                {
                    Console.WriteLine("введите положительное число ");
                    var f = int.TryParse(Console.ReadLine(), out b);
                    if (b >= 0 && f) break;
                    else Console.WriteLine("вы ввели некорректные данные, введите положительное число ");

                }
                if (b % 2 == 0) x = x + 0;
                else x = x + b;
            }
            while (b != 0);
            Console.WriteLine($"{x}");


        }
    }
}
