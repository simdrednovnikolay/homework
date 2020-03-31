using System;


 class Program
 {
  

    static void MinofNum()
    {
        Console.WriteLine("Введите три числа");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int min = a;

        if (a < b && a < c)
            Console.WriteLine("Наименьшее число " + a);
        else if (b < c)
            Console.WriteLine("Наименьшее число " + b);
        else
            Console.WriteLine("Наименьшее число " + c);
    }//Написать метод, возвращающий минимальное из трех чисел

    static void quantOfnum()  // Написать метод подсчета количества цифр числа.
    {
        Console.WriteLine("Введите число");
        int a = int.Parse(Console.ReadLine());

        if (a < 10)
            Console.WriteLine("В введенном числе 1 цифра");
        else if (a < 100)
            Console.WriteLine("В введенном числе 2 цифры");
        else if (a < 1000)
            Console.WriteLine("В введенном числе 3 цифры");
        else if (a < 10000)
            Console.WriteLine("В введенном числе 4 цифры");
        else if (a < 100000)
            Console.WriteLine("В введенном числе 5 цифр");
        else
            Console.WriteLine("Слишком большое число");
    }

    static void pasword(string ul, string up)
    {
        Console.WriteLine("Введите логин");
        ul = Console.ReadLine();

        Console.WriteLine("Введите пароль");
        up = Console.ReadLine();

        string login = "root";
        string pasword = "GeekBrains";

        int i = 0;

        while (i < 3)
        {

            if (ul == login & up == pasword)
                Console.WriteLine("Успешная авторизация");
            else
                Console.WriteLine("Ошибка, попробуйте еще раз");
            ul = Console.ReadLine();
            up = Console.ReadLine();
            i++;

        }

        Console.WriteLine("Вы исчерпали попытки ввода, попробуйте восстановить пароль");
    }  //Реализовать метод проверки логина и пароля.

    static void rec(int b)  //Разработать рекурсивный метод, который выводит на экран числа от a до b
    {


        int a = 0;

        if (b > a)
        {
            Console.WriteLine(b);
            rec(b - 1);
        }


    }
    static void Main(string[] args)
     {
        
     }
 }

