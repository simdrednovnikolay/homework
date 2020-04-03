using System;


struct Complex
{
    public double im;
    public double re;

    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    public Complex Minus(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }
    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    public string ToString()
    {
        return re + "+" + im + "i";
    }

} // Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
class Program
{
    static void Main(string[] args)
    {
        // С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
        //Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
        Console.WriteLine("Введите числа");
        
        bool isNum = int.TryParse(Console.ReadLine(), out  int x);
        int result = 0;
        
        while (!isNum)
        {
            Console.WriteLine("Введено не число.");
            isNum = int.TryParse(Console.ReadLine(), out  x);
           
        }
        int a = x;
        while (a != 0)
        {
            if (a % 2 == 1) result += a;

            a = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine($"Сумма нечетных чисел {result}");
    }
}

