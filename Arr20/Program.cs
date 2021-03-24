using System;
using System.IO;

namespace Arr20
{
    class Program
    {

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
       
