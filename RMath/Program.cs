using System;

namespace RMath
{
    class Program
    {
        //Тимофеев

        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода





        private static double NewMethod(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1 ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1 ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x2 ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2 ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            // double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double r = NewMethod(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками- {r:F2}");
        }


    }
}
