using System;
using System.IO;

namespace D6
{
    public delegate double Fun(double x, double a); // 1.Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
    //Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
    class Program
    {
        public static void Table(Fun F, double x, double b, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |{2,8:0.000} |", x, a, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double Myfun(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }
        public static double MyFun2(double x, double a)
        {
            return a * Math.Sin(x);
        }

        public delegate double Funk(double x); //2. Модифицировать программу нахождения минимума функции так, 
        //чтобы можно было передавать функцию в виде делегата.
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static void SaveFunc(string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            Funk funk = F;
            SaveFunc("data.bin", funk(-100), 100, 0.5); // 2
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();

            Console.WriteLine("Таблица функции a*x^2"); // 1
            Table(Myfun, -2, 5, 2);
            Console.WriteLine("Таблица функции a*sin(x)");
            Table(MyFun2, -2, 5, 2);
        }
    }
}
