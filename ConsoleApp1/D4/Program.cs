using System;
using System.IO;

class Massiv // 2.Дописать класс для работы с одномерным массивом.
{
   
    int[] masiv;
    

    public Massiv(int size, int step)
    {
        masiv = new int[size];
        for(int i=0; i<masiv.Length; i++)
        {
            masiv[i] = (i + 1) * step;
        }
    }

    public void Print()
    {
        for (int j = 0; j < masiv.Length; j++)
            Console.WriteLine(masiv[j]);
    }
    public void Sum()
    {
        int r = 0;
        for(int k =0; k<masiv.Length; k++)
        {
            r += masiv[k];
        }
        Console.WriteLine(r);
    }
    public void Change()
    {
        for (int l = 0; l < masiv.Length; l++)
            masiv[l] = -masiv[l];
    }
    public void Multi(int multi)
    {
        for (int e = 0; e < masiv.Length; e++)
            masiv[e] = multi * masiv[e];
    }
    public void MaxCount()
    {
        int max = masiv[0];
        for(int r=0; r<masiv.Length; r++)
        {
            if (max < masiv[r])
                max = masiv[r];
        }
        Console.WriteLine(max);
    }
    public void Save()
    {
        string file = @"C:\Homework\ConsoleApp1\D4\name.txt";
        StreamWriter sw = new StreamWriter(file);  
        for (int g = 0; g<masiv.Length; g++)
        {
            sw.WriteLine(masiv[g].ToString());
        }
        sw.Close();
        Console.WriteLine("Успешная запись.");
    }
    public void Open()
    {
        string file = @"C:\Homework\ConsoleApp1\D4\name.txt";
        StreamReader sr = new StreamReader(file);
        for (int f = 0; f < masiv.Length; f++)
        {
            masiv[f] = Convert.ToInt32(sr.ReadLine());
        }
        sr.Close();
        Console.WriteLine("Успешное чтение");
    }

} 
class Program
 {
     static void Main(string[] args)
     {
       Massiv a = new Massiv(2,2);
       a.Open();
       a.Print();





        // 1.Дан целочисленный массив из 20 элементов.
        int[] y = new int[20];

        Random r = new Random();

        for (int i = 0; i < y.Length; i++)
        {
            y[i] = r.Next(-10000, 10001);
        }

        for (int j = 0; j < y.Length; j++)
        {
            Console.WriteLine(y[j]);
        }
        int count = 0;

        for (int k = 0; k < y.Length - 1; k++)
        {
            if (y[k] % 3 == 0 || y[k + 1] % 3 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("Колличество пар " + count);



        //3. Решить задачу с логинами из предыдущего урока
        string fl = @"C:\Homework\ConsoleApp1\home4.3\login.txt";
        StreamReader sr = new StreamReader(fl);

        int i = 0;
        int j = 0;


        string[] akk = new string[2];

        for (i = 0; i < 2; i++)
        {
            akk[i] = sr.ReadLine();

        }
        sr.Close();

        Console.WriteLine("Введите логин и пароль");
        string[] user = new string[2];


        for (j = 0; j < user.Length; j++)
            user[j] = Console.ReadLine();

        int count = 0;
        while (count < 2)
        {
            if (akk[0] == user[0] & akk[1] == user[1])
            {
                Console.WriteLine("Успешный вход"); break;
            }

            Console.WriteLine("Не верный логин или пароль, попробуйте еще раз");
            for (j = 0; j < user.Length; j++)
                user[j] = Console.ReadLine();
            count++;
        }
        if (count == 2)
            Console.WriteLine("Ошибка входа, попробуйте восстановить логин или пароль.");



    }
 }

