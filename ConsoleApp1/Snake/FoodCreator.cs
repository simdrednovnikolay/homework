using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class FoodCreator
    {
        int mapWight;
        int mapHight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWight, int mapHight, char sym)
        {
            this.mapWight = mapWight;
            this.mapHight = mapHight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWight - 2);
            int y = random.Next(2, mapHight - 2);
            return new Point(x, y, sym);
        }
    }
}
