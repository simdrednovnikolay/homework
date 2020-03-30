using System;



class Program
{
    static void Main(string[] args)
    {   // Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
        //В результате вся информация выводится в одну строчку.

        Console.WriteLine("Введите ваше Имя");
        string Name = Console.ReadLine();

        Console.WriteLine("Введите вашу Фамилию");
        string LastName = Console.ReadLine();

        Console.WriteLine("Введите ваш Возраст");
        int Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите ваш  Рост");
        int Heist = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите ваш Вес");
        int Weist = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Name + " " + LastName + " " + Age + " " + Heist + " " + Weist);
        Console.WriteLine("{0} {1} {2} {3} {4}", Name, LastName, Age, Heist, Weist);

        //Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
        //где m — масса тела в килограммах, h — рост в метрах

        Console.WriteLine("Введите ваш рост в метрах");
        double Heist1 = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        Console.WriteLine("Введите ваш вес");
        double Weist1 = Convert.ToDouble(Console.ReadLine());

        double Imt = Weist1 / (Heist1 * Heist1);
        Console.WriteLine($"Индекс массы тела равен  {Imt:F2}", Imt);

        //Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        //по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)).
        //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

        Console.WriteLine("Введите координаты");
        double X1 = Convert.ToDouble(Console.ReadLine());
        double X2 = Convert.ToDouble(Console.ReadLine());

        double Y1 = Convert.ToDouble(Console.ReadLine());
        double Y2 = Convert.ToDouble(Console.ReadLine());

        double Result = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        Console.WriteLine($"Расстояние между точками {Result:F2}");

        // Написать программу обмена значениями двух переменных.

        Console.WriteLine("Введите два числа");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"a={a} b={b}");
        int c = 0;

        c = a;
        a = b;
        b = c;
        Console.WriteLine($"Результат обмена значений a={a} b={b}");

        //Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.

        Console.WriteLine("Николай Реднов г.Астрахань");
        Console.SetWindowPosition(22, 54);
    }

}

