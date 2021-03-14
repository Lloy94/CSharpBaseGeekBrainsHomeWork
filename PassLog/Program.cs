using System;

namespace PassLog
{
    class Program
    {
        //Тимофеев
        //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

        static void Main(string[] args)
        {
            string Log = "root";
            string Pass = "GeekBrains";
            bool c = false;
            int count = 0;

            Console.WriteLine("Введите верные логин и пароль, у вас 3 попытки");

            do
            {
                Console.WriteLine($"осталось {3 - count} попыток");
                Console.WriteLine("Введите логин");
                string a = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string b = Console.ReadLine();
                if (a == Log) c = true;
                if (b == Pass) c = true;
                else c = false;
                count++;
            }
            while (c != true && count < 3);

            if (c == true) Console.WriteLine("Пароль введён верно");
            else Console.WriteLine("Неверный пароль, попытки закончены");



        }
    }
}
