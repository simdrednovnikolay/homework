using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        public static ConsoleKeyInfo ConsoleKeyInfo { get; private set; }

        static void Main(string[] args)
        {
            

            HorizontLine UpLine = new HorizontLine(0, 78, 0, '/');
            HorizontLine DownLine = new HorizontLine(0, 78, 24, '/');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '@');
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '@');

            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            Point p = new Point(3, 2, '*');
            Snake snake = new Snake(p, 6, Direction.DOWN);
            snake.Drow();

            Console.SetWindowSize(80, 25);

            FoodCreator foodcreator = new FoodCreator(80, 25, '%');
            Point food = foodcreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood();
                    food.Draw();
                }
                else
                    snake.Move();

                Thread.Sleep(50);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }


        }

        
    }
}
