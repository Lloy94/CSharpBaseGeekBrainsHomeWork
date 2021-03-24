using System;
using System.IO;

namespace ArrayTwoDimensionClass
{
    //Тимофеев
//    * а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
//** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
// ** в) Обработать возможные исключительные ситуации при работе с файлами.

    class MyArrayTwoDim
    {
        int[,] a;

        public void MyArrRead(string path)
        {

            string[] ss = new string[0];
            try
            {
                ss = File.ReadAllLines(path);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File doesnt exist in : " + path);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception catched: " + ex.Message);
            }

            a = new int[ss.Length, ss.Length];

            for (int i = 0; i < ss.Length; i++)
            {
                string[] tempArray = ss[i].Split(' ');
                for (int j = 0; j < ss.Length; j++)
                {
                    a[i, j] = int.Parse(tempArray[j]);
                }
            }
        }

        public void saveIntoFile(string path)
        {
           

            try
            {
                StreamWriter wr = new StreamWriter(path);
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                        wr.Write(a[i, j] + " ");
                    wr.Write(Environment.NewLine);
                }
                wr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File doesnt exist in : " + path);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception catched: " + ex.Message);
            }
        }

        public MyArrayTwoDim(int n)
        {
            a = new int[n, n];
          
        }
        public MyArrayTwoDim(int n, int min, int max)
        {
            a = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = rnd.Next(min, max);
        }
        public int Min
        {
            get
            {
                int min = a[0, 0];
 
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] < min) min = a[i, j];
                return min;
            }
        }

        public int Sum
        { 
            get
            {
                int sum = a[0, 0];

                for (int i = 1; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        sum = sum + a[i, j];
                return sum;
            }
        }

        public int SumMore(int count)
        {
           
                int sum = 0;

            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] >= count) sum = sum + a[i, j];
                    else sum = sum + 0;
            return sum;
                
         
        }
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > max) max = a[i, j];
                return max;
            }
        }

        public void MaxCount(out string count)
        {

            count = "-1, -1";
            int max = Max;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] == max)
                        count = i + ", " + j;

        }



        public int CountPositive
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > 0) count++;
                return count;
            }
        }

        public double Average
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        sum += a[i, j];
                return sum / a.GetLength(0) / a.GetLength(1);
            }

        }
      
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    s += a[i, j] + " ";
                s += "\n"; 

            }
            return s;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
         
        }
    }
}
