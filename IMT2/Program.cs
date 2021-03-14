using System;

namespace IMT2
{
    class Program
    {
        //Тимофеев
        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост ");
            double h = Convert.ToDouble(Console.ReadLine());
            double i = m / (h * h);
            double a = i - 25;
            double b = 18.5 - i;
            if (i >= 18.5 && i <= 25) { Console.WriteLine("Имт в норме "); }
            else if (i > 25) { Console.WriteLine($"У вас ожирение, нужно похудеть на { (a * (h * h)):F0} килограмм "); }
            else Console.WriteLine($"Вам нужно набрать { (b * (h * h)):F0} килограмм ");
        }
    }
}
