using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 7, '?');
            

            Point p2 = new Point(5, 8, '#');
            

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            foreach( Point p3 in pList)
            {
                p3.Draw();
            }
        }

        
    }
}
