using System;

namespace Anket
{
    class Program
    {
        //Тимофеев
        //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        //а) используя склеивание;
        //б) используя форматированный вывод;
        //в) используя вывод со знаком $




        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя ? ");
            var a = Console.ReadLine();
            Console.WriteLine("Ваша фамилия ? ");
            var b = Console.ReadLine();
            Console.WriteLine("Ваш возраст ? ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ваш  рост в метрах ? ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ваш вес в килограммах ? ");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + " " + b + " " + c + " лет " + d + " в метрах  " + e + " килограмм");
            Console.WriteLine("{0} {1} {2} лет {3:F2} в метрах {4:F2} килограмм", a, b, c, d, e);
            Console.WriteLine($"{a} {b} {c} лет {d:F2} в метрах {e:F2} килограмм");


        }
    }
}


