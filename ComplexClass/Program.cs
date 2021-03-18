using System;

namespace ComplexClass
{
    //Тимофеев
    //1.б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    //1.в) Добавить диалог с использованием switch демонстрирующий работу класса.

    class Complex
    {
       
        private double im;
       
        double re;

     
        public Complex()
        {
            im = 0;
            re = 0;
        }


        public Complex(double _im, double re)
        {
                        
            im = _im; 
            this.re = re;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im * im;
            x3.re = x2.re * re;
            return x3;
        }

        public double Im
        {
            get { return im; }
            set
            {
          
                if (value >= 0) im = value;
            }
        }
    
        public override string ToString()
        {
            return im + "+" + re + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Complex complex1;
            complex1 = new Complex(150, 20);
            Complex complex2 = new Complex(64, 15);
            complex2.Im = 15;
            Complex result;
            int i = 2;
            switch (i) {
                case 1: result = complex1.Plus(complex2); Console.WriteLine(result.ToString());
                    break;
                case 2:
                    result = complex1.Minus(complex2); Console.WriteLine(result.ToString());
                    break;
                case 3:
                    result = complex1.Multi(complex2); Console.WriteLine(result.ToString());
                    break;
            }
           

        }
    }
}
