using System;

namespace ConsoleApp1
{


    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)  // Сложение
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Multu(Complex x) // Умножение
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;

        }

        public Complex Minus (Complex x) // Вычитание
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }  // Дописать структуру Complex, добавив метод вычитания комплексных чисел

    
    class Program
    {

        static int  TryIn()
        {
            bool flag;
            int x;

            do
            {
                flag = int.TryParse(Console.ReadLine(), out x);
                if (!flag) Console.WriteLine("Вы ввели не число");
            }
            while (!flag);
            return x;

        }  // Защита от неверного ввода
        static void Main(string[] args)
        {
            //Complex complex1;
            //complex1.re = 3;
            //complex1.im = 3;

            //Complex complex2;
            //complex2.re = 1;
            //complex2.im = 1;

            //Complex result = complex1.Minus(complex2);
            //Console.WriteLine(result.ToString());

            Console.WriteLine("Введите числа");
            int sum = 0;
            int num = 0;
        
            do
            {
                num = TryIn();
                if (num % 2 == 1)
                    sum += num;

            }
            while (num != 0);

            Console.WriteLine("Сумма нечетных чисел " + sum);

            




        }
    }
}
