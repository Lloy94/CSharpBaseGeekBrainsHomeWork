using System;

namespace MyArray
{


    class Program
    {
        //Тимофеев
//        а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
//б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
//в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)


        static void Main(string[] args)
        {

            MyArray array = new MyArray(12, 5, 6);
            Console.WriteLine(array.ToString());
            Console.WriteLine(array.Sum);
            foreach (var e in array.Inverse()) 
            {
                Console.Write($"{e}");
            }
            Console.WriteLine("\n");

            array.Multi(15);
            Console.WriteLine(array.ToString());

            array = new MyArray(10, 1, 0);
            Console.WriteLine(array.ToString());
            Console.WriteLine(array.MaxCount);
        }
    }
}
