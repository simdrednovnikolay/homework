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
            

            HorizontLine UpLine = new HorizontLine(0, 78, 0, '*');
            HorizontLine DownLine = new HorizontLine(0, 78, 24, '*');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '@');
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '@');

            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            Point p = new Point(3, 2, '*');
            Snake snake = new Snake(p, 6, Direction.DOWN);
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.LEFT;
                    if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = Direction.RIGHT;
                    if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Direction.UP;
                    if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Direction.DOWN;
                }

                Thread.Sleep(100);
                snake.Move();
            }


        }

        
    }
}
