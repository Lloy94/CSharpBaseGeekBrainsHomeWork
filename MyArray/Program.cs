using System;

namespace MyArray
{


    class Program
    {
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
