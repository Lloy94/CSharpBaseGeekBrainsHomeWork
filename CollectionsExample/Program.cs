using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace CollectionsExample

//Тимофеев
//    Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
//в) отсортировать список по возрасту студента;
//г) * отсортировать список по курсу и возрасту студента;
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }



    class Program
    {
        static int AgeCompare(Student st1, Student st2)
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());
        }

        static int CourceAndAgeCompare(Student st1, Student st2)
        {
            if (st1.course > st2.course)
                return 1;
            if (st1.course < st2.course)
                return -1;
            if (st1.age > st2.age)
                return 1;
            if (st1.age < st2.age)
                return -1;
            return 0;
        }

        static void Main(string[] args)
        {
            int magistr1= 0;
            int magistr2 = 0;
            List<Student> list = new();
            Dictionary<int, int> cousreFrequency = new();
            DateTime dt = DateTime.Now;
            StreamReader sr = new("..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    if (int.Parse(s[5]) == 6) magistr2++;
                    else if (int.Parse(s[5]) == 5) magistr1++;
                    if (int.Parse(s[6]) > 17 && int.Parse(s[6]) < 21)
                    {
                        if (cousreFrequency.ContainsKey(int.Parse(s[5])))
                            cousreFrequency[int.Parse(s[5])] += 1;
                        else
                            cousreFrequency.Add(int.Parse(s[5]), 1);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }

            }
            sr.Close();
            list.Sort();
            Console.WriteLine("Всего студентов:{0}", list.Count);
            Console.WriteLine("Студентов 6го курса :{0}", magistr2);
            Console.WriteLine("Студентов 5го курса :{0}", magistr1);
            Console.WriteLine("\nСколько студентов в возрасте от 18 до 20 лет на каком курсе учатся.");
            ICollection<int> keys = cousreFrequency.Keys;
            String result = String.Format("{0,-10} {1,-10}\n", "Курс", "Количество студентов");
            foreach (int key in keys)
                result += String.Format("{0,-10} {1,-10:N0}\n",
                                   key, cousreFrequency[key]);
            Console.WriteLine($"\n{result}");
            list.Sort(new Comparison<Student>(AgeCompare));
            Console.WriteLine("\nСортировка студентов по возрасту: ");
            foreach (var v in list) Console.WriteLine($"{v.firstName} {v.age}");

            list.Sort(new Comparison<Student>(CourceAndAgeCompare));
            Console.WriteLine("\nСортировка студентов по курсу и возрасту : ");
            foreach (var v in list) Console.WriteLine($"{v.firstName}, курс {v.course}, возраст {v.age}");
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }


}

