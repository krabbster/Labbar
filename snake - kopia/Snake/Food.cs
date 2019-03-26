using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake
{
    class Food : Entity
    {

        public Food(int x, int y) : base(new Point(x, y))
        {
            
        }

        public int GetX()
        {
            return position.X;
        }

        public int GetY()
        {
            return position.Y;
            
        }

        public override void Draw(Graphics g,Brush brush)
        {
            g.FillEllipse(brush, position.X, position.Y, 9, 9);
        }
    }
}
