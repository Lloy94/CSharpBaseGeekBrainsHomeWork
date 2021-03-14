using System;

namespace Billion
{
    class Program
    {
        //Тимофеев
        //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int i = 1;
            int count = 0;
            while (i <= 100000000)
            {
                if (i % RecursiveSum(i) == 0) { i++; count++; }
                else i++;
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start);



        }

        static long RecursiveSum(long a)
        {
            if (a == 0)
                return 0;
            else return RecursiveSum(a / 10) + a % 10;
        }
    }
}
