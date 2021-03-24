using System;
using System.IO;

namespace LogPass
{

    class Program
    {
        struct Account
        {
            public string Log;
            public string Pass;

            public void LoadFromFile(string filename)
            {
                try
                {
                    StreamReader sr = new StreamReader(filename);

                    Log = sr.ReadLine();

                    Pass = sr.ReadLine();

                    sr.Close();
                }
                catch (Exception) { Console.WriteLine("файл не обнаружен"); }
            }


        }

           static bool CheckPasslog(Account Check)
        {
            if (Check.Log == "root" && Check.Pass == "GeekBrains")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
       {
            Account account;
            account.Log = "";
            account.Pass = "";
            string[] fileName = { "..\\..\\data.txt", "..\\..\\tryData.txt", "..\\..\\reallyTryData.txt" };
            int i = 0;

            bool c = false;


        Console.WriteLine("Введите верные логин и пароль, у вас 3 попытки");

            do
            {
                Console.WriteLine($"осталось {3 - i} попыток");
                Console.WriteLine("Считываем логин с файла");
                account.LoadFromFile(fileName[i]);
                if (CheckPasslog(account) == true) c = true;
                else c = false;
                i++;
            }
            while (c != true && i< 3);

            if (c == true) Console.WriteLine("Пароль введён верно");
            else Console.WriteLine("Неверный пароль, попытки закончены");



        }
    }
}
