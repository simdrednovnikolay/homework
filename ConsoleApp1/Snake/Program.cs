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
            
            Point p = new Point(3, 2, '*');
            Snake snake = new Snake(p, 6, Direction.DOWN);
            snake.Drow();

            //Console.SetWindowSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            FoodCreator foodcreator = new FoodCreator(80, 25, '%');
            Point food = foodcreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(walls.IsHit(snake)|| snake.IsHitTail())
                {
                    Console.WriteLine("Конец игры!");
                    break;
                }
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
