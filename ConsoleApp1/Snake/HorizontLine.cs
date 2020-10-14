using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontLine
    {
        List<Point> pList;

        public HorizontLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();

            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
