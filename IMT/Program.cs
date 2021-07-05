using System;

namespace IMT
{
    class Program
    {
        //Тимофеев

        //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела (ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах

        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост ");
            double h = Convert.ToDouble(Console.ReadLine());
            double i = m / (h * h);
            Console.WriteLine($"имт - {i:F2}");
        }
    }
}
