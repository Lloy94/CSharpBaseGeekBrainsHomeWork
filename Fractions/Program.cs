using System;

namespace Fractions
{
    //Тимофеев
//    * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
// * Добавить свойства типа int для доступа к числителю и знаменателю;
//* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
//*** Добавить упрощение дробей.
    class fractions
    {
        public int num;
        public int denum;

        public fractions()
        {

        }

        public fractions(int num, int denum)
        {

            this.num = num;
            this.denum = denum;
            if (denum == 0) throw new ArgumentException("Знаменатель не может быть равен 0");

        }

        public fractions(double dec)
        { dec = num / denum; }
            


        public fractions Plus(fractions x2)
        {
            fractions x3 = new fractions ();
            x3.num = (num *x2.denum + denum *x2.num)/denum;
            x3.denum = x2.denum;
            return x3;
        }

        public fractions Minus(fractions x2)
        {
            fractions x3 = new fractions();
            x3.num = (num * x2.denum - denum * x2.num) / denum;
            x3.denum = x2.denum;
            return x3;
        }

        public fractions Multi(fractions x2)
        {
            fractions x3 = new fractions();
            x3.num = num*x2.num;
            x3.denum = denum*x2.denum;
            return x3;
        }

        public fractions Div(fractions x2)
        {
            fractions x3 = new fractions();
            x3.num = num * x2.denum;
            x3.denum = denum * x2.num;
            return x3;
        }
        public override string ToString()
       {
            return num + "/" + denum ;
            
       }
        private  string Decimation()
        {
           double num = Convert.ToDouble(this.num);
            double denum = Convert.ToDouble(this.denum);
            double dec = num / denum;
            string dec1 = Convert.ToString(dec);
                return dec1;
        }

        static int NOD(int a, int b)
        {
            while (a != b)
            {
                if (a == 0)
                    break;
                if (a > b) a = a - b; else b = b - a;
            }
            return a;
        }

        public void Simplification()
        {
            int num = this.num;
            int denom = this.denum;
            int nod = NOD((num), (denom));
            while (nod != 1 && nod != 0)
            {
                this.num = num / nod;
                this.denum = denom / nod;
                num = this.num;
                denom = this.denum;
                nod = NOD((num), (denom));
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите числитель первой дроби");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите знаменатель первой дроби");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите числитель второй дроби");
            int denum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите знаменатель второй дроби");
            int denum2 = Convert.ToInt32(Console.ReadLine());
            fractions fractions1 = new fractions(num1,num2);
           fractions fractions2 = new fractions(denum1, denum2);
           fractions result = fractions1.Div(fractions2);
            result.Simplification();
           Console.WriteLine(result.ToString());
            fractions result1 = fractions1.Plus(fractions2);
            result1.Simplification();
            Console.WriteLine(result1.ToString());
            fractions result2 = fractions1.Minus(fractions2);
            result2.Simplification();
            Console.WriteLine(result2.ToString());
            fractions result3 = fractions1.Multi(fractions2);
            result3.Simplification();
            Console.WriteLine(result3.ToString());
            //Console.WriteLine(result.Decimation());
            //Console.WriteLine(result1.Decimation());
            //Console.WriteLine(result2.Decimation());
            //Console.WriteLine(result3.Decimation());


        }
    }
}
