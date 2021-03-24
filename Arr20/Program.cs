using System;
using System.IO;

namespace Arr20
{
    class Program
    {
        //Тимофеев
//        Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//        б) *Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
//        в)**Добавьте обработку ситуации отсутствия файла на диске.
        static void Main(string[] args)
        {
            //int[] array = new int[20];
            //Random rnd = new();
            //int i;
            //int pair = 0;
            //for (i = 0; i < 20; i++)
            //    array[i] = rnd.Next(-10000, 10000);
            //for (i = 1; i < 20; i += 2)
            //    if (array[i] % 3 == 0 ^ array[i - 1] == 0) { Console.Write($"  {array[i]} {array[i - 1]} "); pair++; };
            //Console.ReadLine();
            //Console.WriteLine($"Количество пар в которых на 3 делится только одно число - {pair} ");
            try { int []array = StaticClass.MyArrRead("file.txt");
                foreach (var e in array) 
                { Console.Write($"{e}");
                }
                Console.WriteLine();
                Console.WriteLine(StaticClass.PairCounting(array));
            }
            catch(Exception) 
            {
                Console.WriteLine("Файл не найден");
            }
        }
    }

      static class StaticClass
    {


   

       static public int [] MyArrRead(string path)
        {

            

                string[] ss = File.ReadAllLines(path);
                int [] c = new int[ss.Length];

            for (int i = 0; i < ss.Length; i++) {
                c[i] = int.Parse(ss[i]); }
            return c;



        }





        public static int PairCounting(int[] c)
        {
            int pairCount = 0;              
                for (int i = 1; i < c.Length; i += 2)
                    if (c[i] % 3 == 0 ^ c[i - 1] == 0) pairCount++;
                return pairCount;
            
        }
        
    }
}
       
