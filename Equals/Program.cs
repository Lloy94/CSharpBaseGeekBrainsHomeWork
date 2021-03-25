using System;

namespace Equals
{

    //Тимофеев
    //*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    //Например:
    //badc являются перестановкой abcd.

    class Program
    {
        public static bool Equal(string a, string b)
        {
            bool check = false;
            if (a.Length == b.Length && StringFreq(a) == StringFreq(b)) check = true;
         else  check = false;
            return check;
        }

        public static string StringFreq(string s) 
        {
            int[] count = new int[26];
            int i, k, cA;
            char c;
            cA = (int)('a'); 
            for (i = 0; i < 26; i++) count[i] = 0;
            s += '.';     
            i = 0;
            string result = "";
            do
            {
                c = s[i]; 
                k = (int)c;
                if (c >= 'a' && c <= 'z')
                    count[k - cA]++;
                i++;
            }
            while (c != '.');
            for (i = 0; i < 26; i++)
                if (count[i] > 0)
                    result+= $"{(char)(cA + i)}{count[i]} ";
            return result;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку");
            string a = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string b  = Console.ReadLine();
            bool f = Equal(a, b);
            if (f == true) Console.WriteLine("строки являются переставлением");
            else Console.WriteLine("строки не являются переставлением");


        }
    }
}
