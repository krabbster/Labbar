using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Entity
    {
        

        public Snake(int x, int y): base(new Point(x, y))
        {
            
        }
        public override void Draw(Graphics g, Brush brush)
        {
                g.FillRectangle(brush, new Rectangle(position.X, position.Y, 9, 9));      
        }
        public void Move()
        {
            position.X = position.X + speed.X;
            position.Y = position.Y + speed.Y;
        }

        public int GetX()
        {
            return position.X;
        }

        public int GetY()
        {
            return position.Y;
        }

        private Vector speed;

        public Vector Speed
        {
            get { return speed; }
            set { speed = value; }
        }

    }
}
