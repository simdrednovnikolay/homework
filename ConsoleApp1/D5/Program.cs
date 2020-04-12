using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Message // 2. Разработать класс Message, содержащий следующие статические методы для обработки
{
    StreamReader sr = new StreamReader("file.txt");
    public void A(int b) // Вывести только те слова сообщения, которые содержат не более n букв.
    {
        string x = sr.ReadToEnd();
        string y = x.Replace(" ", "");
        string[] name = y.Split(' ', '.', ',', '!', ':');
        foreach (string word in name)
            if (word.Length < b)
                Console.WriteLine("{0}", word);  
    }
    public void B(char w) // Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    {
        string x = sr.ReadToEnd();
        string y = x.Replace(" ", "");
        string[] name = y.Split(' ', '.', ',', '!', ':');

        for (int i = 0; i < name.Length; i++)
            Console.WriteLine((Regex.Replace(name[i], $@"\s*\w*{w}\b", "").Trim()));
    }
    public string C() // Найти самое длинное слово сообщения.
    {
        string x = sr.ReadToEnd();
        string y = x.Replace(" ", "");
        string[] name = y.Split(' ', '.', ',', '!', ':');
        int j = 0;
        string mw = name[0];
        int ix = 0;
        for (j = 1; j < name.Length; j++ )
            if(name[j].Length > mw.Length)
            {
                mw = name[j];
                ix = j;
                
            }
        Console.WriteLine(name[ix]);
        return mw;
    }
    public void D() // Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    {
        string[] name = System.IO.File.ReadAllLines("file.txt");
        StringBuilder sb = new StringBuilder();
        for (int k = 0; k < name.Length; k++)
            sb.Append(C());

        string st = sb.ToString();
        Console.WriteLine(st);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "file.txt");
        Message m = new Message();
        


        // Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов.
        StreamReader sr = new StreamReader("file.txt");

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

        //string a = Console.ReadLine();   
        //Regex myReg = new Regex(@"\d{1}\w{2,10}");

        //Console.WriteLine(myReg.IsMatch(a));

        string log = Console.ReadLine();
        int num;
        bool isNum = int.TryParse(log, out num);


        if (isNum || log.Length < 2 || log.Length > 10)
            Console.WriteLine("логин не может начинаться с цифры и быть короче 2 и длиннее 10 символов");

        else
        {
            for (j = 0; j < user.Length; j++)
            {
                user[0] = log;
                user[1] = Console.ReadLine(); break;
            }

        }

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
