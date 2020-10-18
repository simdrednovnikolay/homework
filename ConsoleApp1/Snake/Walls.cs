using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWight, int mapHight)
        {
            wallList = new List<Figure>();
            HorizontLine UpLine = new HorizontLine(0, mapWight-2, 0, '+');
            HorizontLine DownLine = new HorizontLine(0, mapWight - 2, mapHight-1, '+');
            VerticalLine LeftLine = new VerticalLine(0, mapHight - 1, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, mapHight - 1, mapWight - 2, '+');

            wallList.Add(UpLine);
            wallList.Add(DownLine);
            wallList.Add(RightLine);
            wallList.Add(LeftLine);

        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
                wall.Drow();
        }
    }
}
