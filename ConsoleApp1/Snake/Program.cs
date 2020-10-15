using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
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

            Point p = new Point(6, 7, '@');
            Snake snake = new Snake(p, 6, Direction.UP);
            snake.Drow();

        }

        
    }
}
