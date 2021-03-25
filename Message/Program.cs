using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace Message
{

    //Тимофеев
    //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения,  которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.


    class Program
    {
        public static string LessWords(StringBuilder text, int n)
        {
            string result = "";
            for (int i = 0; i < text.Length;)
                if (char.IsPunctuation(text[i])) text.Remove(i, 1);
                else ++i;
            string str = text.ToString();
            string[] s = str.Split(' ');
            for (int i = 0; i < s.Length; ++i)
                if (s[i].Length <= n) result += $"{s[i]} ";
            return result;
        }

        public static string RemoveWords(StringBuilder text, char a)
        {
            string result = "";
            for (int i = 0; i < text.Length;)
                if (char.IsPunctuation(text[i])) text.Remove(i, 1);
                else ++i;
            string str = text.ToString();
            string[] s = str.Split(' ');
            for (int i = 0; i < s.Length; ++i)
                if (s[i][s[i].Length - 1] != a) result += $"{s[i]} ";
            return result;
        }

        static public string LongestWord(StringBuilder text)
        {
            for (int i = 0; i < text.Length;)
                if (char.IsPunctuation(text[i])) text.Remove(i, 1);
                else ++i;
            string str = text.ToString();
            string[] s = str.Split(' ');
            string result = s[0];
            int max = s[0].Length;
            foreach (string word in s)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    result = word;
                }
            }
            return result;
        }

        static public StringBuilder LongestWords(StringBuilder text)
        {
            int max = LongestWord(text).Length;
            for (int i = 0; i < text.Length;)
                if (char.IsPunctuation(text[i])) text.Remove(i, 1);
                else ++i;
            string str = text.ToString();
            string[] s = str.Split(' ');
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < s.Length; ++i)
                if (s[i].Length == max) result.Append($"{s[i]} ");
            return result;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            StringBuilder a = new(Console.ReadLine());
            Console.WriteLine("Исходная строка: " + a);
            string b = LessWords(a, 5);
            Console.WriteLine(b);
            string d = RemoveWords(a,'а');
            Console.WriteLine(d);
            string e = LongestWord(a);
            Console.WriteLine(e);
            StringBuilder f = LongestWords(a);
            Console.WriteLine(f);

        }

    }
}
