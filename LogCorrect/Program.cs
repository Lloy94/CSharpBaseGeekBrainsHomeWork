using System;
using System.Text.RegularExpressions;

namespace LogCorrect
{

    //Тимофеев
    //Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    //а) без использования регулярных выражений;
    //б) ** с использованием регулярных выражений.
    class Program
    {
       static bool LogCheck(string text)
        {
            int n = text.Length;
            bool b = false;
            char c = text[0];
            if ((c >= 'a' && c <= 'z' || c >= 'A' && c <= 'z') && n >= 2 && n <= 10)
            {
                for (int i = 1; i < n; i++)
                {
                    c = text[i];
                    if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'z' || c >= '0' && c <= '9') b = true;
                    else { b = false; break; }
                }
            }
            else return b;
            return b;
        }
        static bool LogCheckRegular(string text)
        {
            string pattern = "^[A-Za-z][A-Za-z0-9]{1,9}$";
            Regex regex = new Regex(pattern);
            bool e = regex.IsMatch(text);
            return e;
        }
   
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из 2 до 10 символов, содержащаю только буквы латинского алфавита или цифры, при этом цифра не может быть первой ");
            string log = Console.ReadLine();
            //bool a = LogCheck(log);
            //if (a == true) Console.WriteLine("Логин корректный");
            //else Console.WriteLine("Некорректный логин");
            bool a = LogCheckRegular(log);
            if (a == true) Console.WriteLine("Логин корректный");
            else Console.WriteLine("Некорректный логин");
        }
    }
}
